using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageMaskApply
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int ImageBorderPower => trackBarBorderPower.Value;

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            file.Filter = "Image Files(*.PNG;*.JPEG;*.JPG)|*.PNG;*.JPEG;*.JPG";

            var dialogResult = file.ShowDialog();

            if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Yes)
            {
                Bitmap image = new Bitmap(file.FileName);

                pctrCurrentImageOld.Image = image;

                Bitmap newMaskAppliedImage = ApplyMaskToImage(in image);

                pctrCurrentImageNew.Image = newMaskAppliedImage;

                trackBarBorderPower.Enabled = true;
                btnApply.Enabled = true;
                //image = null;
                //newMaskAppliedImage = null;
            }
            else
            {
                MessageBox.Show("Lütfen bir görsel seçiniz!");
            }
        }

        /// <summary>
        /// Applies a mask to the given image in bitmap format and the result is returned as a new Bitmap file.
        /// </summary>
        /// <param name="image">image type as Bitmap</param>
        /// <returns></returns>
        private Bitmap ApplyMaskToImage(in Bitmap image)
        {
            Bitmap copyImage = image.Clone() as Bitmap;

            List<Color> differentColors = GetDifferentColorListInBitmap(copyImage, 10);
            List<BitmapRowDetail> borderCoordinateList = GetBorderCoordinates(copyImage);

            ApplyShuffleColor(copyImage, borderCoordinateList, differentColors);

            return copyImage;
        }

        /// <summary>
        /// This method to be applied color list for every row in image.
        /// </summary>
        /// <param name="image">Image as Bitmap type</param>
        /// <param name="borderCoordinateList">Object border coordinates for every row</param>
        /// <param name="colors">Color list to be applied</param>
        private void ApplyShuffleColor(Bitmap image, List<BitmapRowDetail> borderCoordinateList, List<Color> colors)
        {
            Random random = new Random();

            for (int i = 0; i < borderCoordinateList.Count; i++)
            {
                for (int j = borderCoordinateList[i].StartColumn; j < borderCoordinateList[i].EndColumnd; j++)
                {
                    var randomNumber = random.Next(0, colors.Count());

                    image.SetPixel(i, j, colors[randomNumber]);
                }
            }
        }

        /// <summary>
        /// Return object border coordinates for every row.
        /// </summary>
        /// <param name="image">Image as Bitmap type</param>
        /// <returns></returns>
        private List<BitmapRowDetail> GetBorderCoordinates(Bitmap image)
        {
            List<BitmapRowDetail> borderCoordinateList = new List<BitmapRowDetail>();

            for (int i = 1; i < image.Width - 1; i++)
            {
                BitmapRowDetail rowDetail = new BitmapRowDetail();

                rowDetail.Row = i;

                for (int j = 1; j < image.Height - 1; j++)
                {
                    Color cr = image.GetPixel(i + 1, j);
                    Color cl = image.GetPixel(i - 1, j);
                    Color cu = image.GetPixel(i, j - 1);
                    Color cd = image.GetPixel(i, j + 1);
                    int dx = cr.R - cl.R;
                    int dy = cd.R - cu.R;
                    double power = Math.Sqrt(dx * dx / 4 + dy * dy / 4);

                    if (power > ImageBorderPower)
                    {
                        if (rowDetail.StartColumn == 0)
                        {
                            rowDetail.StartColumn = j;
                        }
                        else
                        {
                            rowDetail.EndColumnd = j;
                        }
                    }
                }

                borderCoordinateList.Add(rowDetail);
            }

            return borderCoordinateList;
        }

        /// <summary>
        /// Given different colors in image.
        /// </summary>
        /// <param name="image">Image as Bitmap type</param>
        /// <param name="count">Different colors count</param>
        /// <returns></returns>
        private List<Color> GetDifferentColorListInBitmap(Bitmap image, int count)
        {
            List<Color> colors = new List<Color>();

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    var color = image.GetPixel(x, y);
                    colors.Add(color);
                }
            }

            return colors
                .GroupBy(i => i)
                .Select(group => new
                {
                    Key = group.Key,
                    Count = group.Count()
                })
                .OrderByDescending(i => i.Count)
                .Take(count)
                .Select(i => i.Key)
                .ToList();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var image = pctrCurrentImageOld.Image as Bitmap;

            Bitmap newMaskAppliedImage = ApplyMaskToImage(in image);

            pctrCurrentImageNew.Image = newMaskAppliedImage;

            newMaskAppliedImage.Save("saved.jpg");
        }
    }

    /// <summary>
    /// BitmapRowDetail represent object border coordinates for every row.
    /// </summary>
    class BitmapRowDetail
    {
        public int Row { get; set; }
        public int StartColumn { get; set; }
        public int EndColumnd { get; set; }
    }
}
