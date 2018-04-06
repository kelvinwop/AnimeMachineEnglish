using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;

namespace AnimeMachineEnglish
{
    /// <summary>
    /// file used for toolbar click event handling
    /// </summary>
    partial class Form1
    {
        /// <summary>
        /// File > New
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redraw = false;
            im_eyes = theNullImage;
            im_face = theNullImage;
            im_hairBack = theNullImage;
            im_hairFront = theNullImage;
            im_head = theNullImage;
            im_outfit = theNullImage;
            im_bodyBack = theNullImage;

            lbx_Outfit.SelectedIndex = 0;
            lbx_Head.SelectedIndex = 0;
            lbx_HairFront.SelectedIndex = 0;
            lbx_HairBack.SelectedIndex = 0;
            lbx_Face.SelectedIndex = 0;
            lbx_Eyes.SelectedIndex = 0;

            redraw = true;
            RedrawImage();
        }

        /// <summary>
        /// File > Open
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// File > Save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(sfd_SaveFile.FileName=="")
            {
                DialogResult dr = sfd_SaveFile.ShowDialog();
                if(dr==DialogResult.OK)
                {
                    EngineTools.Save(sfd_SaveFile);
                }
            }
        }

        /// <summary>
        /// File > Save As
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = sfd_SaveFile.ShowDialog();
            if(dr == DialogResult.OK)
            {
                EngineTools.Save(sfd_SaveFile);
            }
        }

        /// <summary>
        /// File > Brexit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    partial class EngineTools
    {
        public static void Save(SaveFileDialog sfd)
        {
            //check one last time
            if (sfd.FileName == "")
                return;

            //index is 1 based
            switch(sfd.FilterIndex)
            {
                case 1://png
                    break;
                default:
                    break;
            }

            throw new NotImplementedException();
        }

        private void saveJpeg(string path, Bitmap img, long quality)
        {
            // Encoder parameter for image quality

            EncoderParameter qualityParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);

            // Jpeg image codec
            ImageCodecInfo jpegCodec = this.getEncoderInfo("image/jpeg");

            if (jpegCodec == null)
                return;

            EncoderParameters encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = qualityParam;

            img.Save(path, jpegCodec, encoderParams);
        }

        private ImageCodecInfo getEncoderInfo(string mimeType)
        {
            // Get image codecs for all image formats
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            // Find the correct image codec
            for (int i = 0; i < codecs.Length; i++)
                if (codecs[i].MimeType == mimeType)
                    return codecs[i];
            return null;
        }
    }
}

namespace ImageLibrary
{
    /// <summary>
    /// the new and improved...
    /// </summary>
    public class Image2
    {
        public RGBA[,] ColorData;
        public Image2(int xsize, int ysize)
        {
            ColorData = new RGBA[ysize, xsize];
            Parallel.For(0, ysize, y =>
            {
                Parallel.For(0, xsize, x =>
                {
                    ColorData[y, x].Red = 0;
                    ColorData[y, x].Green = 0;
                    ColorData[y, x].Blue = 0;
                    ColorData[y, x].Alpha = 0;
                });
            });
        }

        public Image2(RGBA[,] inputData)
        {
            ColorData = inputData;
        }

        public override bool Equals(object obj)
        {
            if (obj is Image2)
            {
                Image2 other = (Image2)obj;
                if(ColorData.GetLength(0)==other.ColorData.GetLength(0)&& ColorData.GetLength(1) == other.ColorData.GetLength(1))
                {
                    bool mismatch_found = false;
                    Parallel.For(0, ColorData.GetLength(0), (y, loopState) =>
                    {
                        Parallel.For(0, ColorData.GetLength(1), (x, loopState2) =>
                        {
                            if (!ColorData[y, x].Equals(other.ColorData[y, x]))
                            {
                                loopState.Stop();
                                loopState2.Stop();
                                mismatch_found = true;
                            }
                        });
                    });
                    if (mismatch_found)
                        return false;
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            double sum = 0;
            object thisLock = new object();
            Parallel.For(0, Math.Min(100, ColorData.GetLength(0)), x =>
            {
                lock(thisLock)
                {
                    sum += ColorData[0,x].Red;
                }
            });
            return (int)sum;
        }
    }

    public struct RGBA
    {
        private double _Red, _Green, _Blue, _Alpha;
        public double Red
        {
            get { return _Red; }
            set
            {
                if(value >= 0 && value <= 255)
                {
                    _Red = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public double Green
        {
            get { return _Green; }
            set
            {
                if (value >= 0 && value <= 255)
                {
                    _Green = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public double Blue
        {
            get { return _Blue; }
            set
            {
                if (value >= 0 && value <= 255)
                {
                    _Blue = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public double Alpha
        {
            get { return _Alpha; }
            set
            {
                if (value >= 0 && value <= 255)
                {
                    _Alpha = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public RGBA(double r, double g, double b, double a)
        {
            if(isCompliant(r)&& isCompliant(g)&&isCompliant(b)&&isCompliant(a))
            {
                _Red = r;
                _Green = g;
                _Blue = b;
                _Alpha = a;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public static bool isCompliant(double val)
        {
            return (val >= 0 && val <= 255);
        }

        public override bool Equals(object obj)
        {
            if(obj is RGBA)
            {
                RGBA other = (RGBA)obj;
                return (Red == other.Red && Green == other.Green && Blue == other.Blue && Alpha == other.Alpha);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (int)_Alpha;
        }
    }
}