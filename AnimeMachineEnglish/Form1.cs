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
    public partial class Form1 : Form
    {
        public Form1()
        {
            theNullImage = EngineTools.CreateTransparent(300, 400);
            im_eyes = theNullImage;
            im_face = theNullImage;
            im_hairBack = theNullImage;
            im_hairFront = theNullImage;
            im_head = theNullImage;
            im_outfit = theNullImage;
            im_bodyBack = theNullImage;
            redraw = true; //flag used when mass deselecting to prevent ultralag

            InitializeComponent();
            InitializeOptions();

            imbx_ImagePrimary.FunctionalMode = ImageBox.FunctionalModeOption.Minimum;
        }


        string[] filesHairFront;
        string[] filesHairBack;
        string[] filesHead;
        string[] filesEyes;
        string[] filesFace;
        string[] filesOutfit;
        /// <summary>
        /// Initialize the options by searching data directories for image files
        /// </summary>
        public void InitializeOptions()
        {
            //hair front
            filesHairFront = EngineTools.GetFiles("hair_front");
            lbx_HairFront = EngineTools.PrepWindow(filesHairFront, lbx_HairFront);

            //hair back
            filesHairBack = EngineTools.GetFiles("hair_back");
            lbx_HairBack = EngineTools.PrepWindow(filesHairBack, lbx_HairBack);

            //head
            filesHead = EngineTools.GetFiles("head");
            lbx_Head = EngineTools.PrepWindow(filesHead, lbx_Head);

            //eyes
            filesEyes = EngineTools.GetFiles("eye");
            lbx_Eyes = EngineTools.PrepWindow(filesEyes, lbx_Eyes);

            //face
            filesFace = EngineTools.GetFiles("face_front");
            lbx_Face = EngineTools.PrepWindow(filesFace, lbx_Face);

            //outfit
            filesOutfit = EngineTools.GetFiles("body_front");
            lbx_Outfit = EngineTools.PrepWindow(filesOutfit, lbx_Outfit);
        }

        Image<Bgra, byte> im_hairFront;
        Image<Bgra, byte> im_hairBack;
        Image<Bgra, byte> im_head;
        Image<Bgra, byte> im_face;
        Image<Bgra, byte> im_eyes;
        Image<Bgra, byte> im_outfit;
        Image<Bgra, byte> im_bodyBack;
        Image<Bgra, byte> theNullImage;
        bool redraw { get; set; }

        private void ArticleSelected(ListBox lbx, string path, out Image<Bgra,byte> image)
        {
            if (lbx.SelectedIndex <= 0)
            {
                image = theNullImage;
            }
            else
            {
                image = CvInvoke.Imread("default/" + path + "/" + lbx.GetItemText(lbx.SelectedItem), ImreadModes.Unchanged).ToImage<Bgra, byte>();
            }
            if(redraw)
                RedrawImage();
        }

        private void lbx_HairFront_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = "hair_front";
            ArticleSelected(lbx_HairFront, path, out im_hairFront);
        }

        private void lbx_HairBack_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = "hair_back";
            ArticleSelected(lbx_HairBack, path, out im_hairBack);
        }

        private void lbx_Head_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = "head";
            ArticleSelected(lbx_Head, path, out im_head);
        }

        private void lbx_Face_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = "face_front";
            ArticleSelected(lbx_Face, path, out im_face);
        }

        private void lbx_Eyes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = "eye";
            ArticleSelected(lbx_Eyes, path, out im_eyes);
        }

        private void lbx_Outfit_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = "body_front";
            ArticleSelected(lbx_Outfit, path, out im_outfit);
            path = "body_back";
            ArticleSelected(lbx_Outfit, path, out im_bodyBack);
        }

        private void lbx_AccessList_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbx_EquippedAccessories_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn_AddAccessory_Click(object sender, EventArgs e)
        {

        }

        private void RedrawImage()
        {
            //imbx_ImagePrimary.Image = im_hairFront; //working

            imbx_ImagePrimary.Image = AddImages(new Image<Bgra, byte>[] { im_hairBack, im_bodyBack, im_outfit, im_head, im_hairFront,im_face,im_eyes});
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private Image<Bgra, byte> AddImages(Image<Bgra, byte>[] imageArray)
        {
            if (imageArray == null || imageArray.Length == 0)
                throw new Exception("wtf parameters are empty bro");
            int _height = imageArray[0].Height;
            int _width = imageArray[0].Width;
            foreach (Image<Bgra, byte> i in imageArray)
            {
                if (i.Height != _height || i.Width != _width)
                    throw new Exception("Array of images are not of the same dimensions");
            }
            //data cleaned

            Image<Bgra, byte> output = EngineTools.CreateTransparent(_width, _height);
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    Bgra pixeldata = new Bgra(0, 0, 0, 0);
                    List<double> alphaArray = new List<double>();
                    for (int i = 0; i < imageArray.Length; i++) //check to see if layers have anything on them at all, skip math if there is
                    {
                        alphaArray.Add(imageArray[i][y, x].Alpha);
                    }
                    if (alphaArray.Sum() <= 0.001)
                        goto SkipSum;
                    for (int i = 0; i < imageArray.Length; i++)
                    {
                        if (imageArray[i][y, x].Alpha > 0.001)
                        {
                            double a1 = imageArray[i][y, x].Alpha / 255;
                            double r1 = imageArray[i][y, x].Red;
                            double g1 = imageArray[i][y, x].Green;
                            double b1 = imageArray[i][y, x].Blue;
                            double a2 = pixeldata.Alpha / 255;
                            double r2 = pixeldata.Red;
                            double g2 = pixeldata.Green;
                            double b2 = pixeldata.Blue; //stacking value 2 over value 1

                            //additive compositing
                            pixeldata.Alpha = (a2 * (1 - a1) + a1) * 255; //x255 because scale of 0-255
                            pixeldata.Red = r2 * a2 * (1 - a1) + r1 * a1;
                            pixeldata.Green = g2 * a2 * (1 - a1) + g1 * a1;
                            pixeldata.Blue = b2 * a2 * (1 - a1) + b1 * a1;
                        }
                    }
                    SkipSum: //cancel excecution of adding nothing to itself
                    output[y, x] = pixeldata;
                }
            }
            return output;
        }

        
    }

    public partial class EngineTools
    {
        public static string[] GetFiles(string foldername)
        {
            string[] allfiles = System.IO.Directory.GetFiles("default/"+foldername, "*.*", System.IO.SearchOption.AllDirectories);
            for(int i=0;i<allfiles.Length;i++)
            {
                allfiles[i] = Regex.Split(allfiles[i], "\\\\")[1];
            }
            return allfiles;
        }

        public static ListBox PrepWindow(string[] fileList, ListBox prepareTarget)
        {
            prepareTarget.Items.Add("None");
            prepareTarget.SetSelected(0, true);
            foreach (string s in fileList)
            {
                prepareTarget.Items.Add(s);
            }
            return prepareTarget;
        }

        public static Image<Bgra,byte> CreateTransparent(int x, int y)
        {
            Mat m = new Mat(y, x, DepthType.Cv8U, 4);
            m.SetTo(new MCvScalar(255, 255, 255, 0));
            return m.ToImage<Bgra, byte>();
        }
    }

    //depreciated
    public class Layer
    {
        Bitmap layerData;
        int layerPriority;
        float opacity;

        public Layer(Bitmap img)
        {
            layerData = img;
            layerPriority = 0;
        }

        public Layer(Bitmap layerData, int layerPriority)
        {
            this.layerData = layerData;
            this.layerPriority = layerPriority;
        }

        public delegate Tuple<int, int, int> Operation(int r, int g, int b);
        public delegate Tuple<int, int, int> OperationDouble(int r1, int r2, int g1, int g2, int b1, int b2);

        /// <summary>
        /// perform operation op on each bit of the image. Uses Lockbits and parallel execution
        /// </summary>
        /// <param name="processedBitmap"></param>
        /// <param name="op"></param>
        public static void ProcessImage_1(Bitmap processedBitmap, Operation op)
        {
            unsafe
            {
                BitmapData bitmapData = processedBitmap.LockBits(new Rectangle(0, 0, processedBitmap.Width, processedBitmap.Height), ImageLockMode.ReadWrite, processedBitmap.PixelFormat);

                int bytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(processedBitmap.PixelFormat) / 8;
                int heightInPixels = bitmapData.Height;
                int widthInBytes = bitmapData.Width * bytesPerPixel;
                byte* PtrFirstPixel = (byte*)bitmapData.Scan0;
                Tuple<int, int, int> outp;

                Parallel.For(0, heightInPixels, y =>
                {
                    byte* currentLine = PtrFirstPixel + (y * bitmapData.Stride);
                    for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                    {
                        int oldBlue = currentLine[x];
                        int oldGreen = currentLine[x + 1];
                        int oldRed = currentLine[x + 2];

                        outp = op(oldRed, oldGreen, oldBlue);

                        currentLine[x] = (byte)outp.Item3;//blue
                        currentLine[x + 1] = (byte)outp.Item2;//green
                        currentLine[x + 2] = (byte)outp.Item1;//red
                    }
                });
                processedBitmap.UnlockBits(bitmapData);
            }
        }

        /// <summary>
        /// perform operation op on each bit of the image, also using inputs from a second image. Uses Lockbits and parallel execution
        /// </summary>
        /// <param name="bitmap1"></param>
        /// <param name="bitmap2"></param>
        /// <param name="op"></param>
        public static void ProcessImage_2(Bitmap bitmap1, Bitmap bitmap2, OperationDouble op)
        {
            unsafe
            {
                BitmapData bitmapData1 = bitmap1.LockBits(new Rectangle(0, 0, bitmap1.Width, bitmap1.Height), ImageLockMode.ReadWrite, bitmap1.PixelFormat);
                BitmapData bitmapData2 = bitmap2.LockBits(new Rectangle(0, 0, bitmap2.Width, bitmap2.Height), ImageLockMode.ReadWrite, bitmap2.PixelFormat);

                int bytesPerPixel1 = System.Drawing.Bitmap.GetPixelFormatSize(bitmap1.PixelFormat) / 8;
                int bytesPerPixel2 = System.Drawing.Bitmap.GetPixelFormatSize(bitmap2.PixelFormat) / 8;
                int heightInPixels1 = bitmapData1.Height;
                int heightInPixels2 = bitmapData2.Height;
                int widthInBytes1 = bitmapData1.Width * bytesPerPixel1;
                int widthInBytes2 = bitmapData2.Width * bytesPerPixel2;
                byte* PtrFirstPixel1 = (byte*)bitmapData1.Scan0;
                byte* PtrFirstPixel2 = (byte*)bitmapData2.Scan0;

                if(bytesPerPixel1 != bytesPerPixel2 || heightInPixels1 != heightInPixels2 || widthInBytes1 != widthInBytes2)
                {
                    throw new Exception(string.Format("Dimensions and properties of images do not match:\nBytes Per Pixel1: {0}\nBytes Per Pixel2: {1}\nHeight In Pixels1: {2}\nHeight In Pixels2: {3}\n Width In Bytes1: {4}\nWidth in Bytes2: {5}", bytesPerPixel1, bytesPerPixel2, heightInPixels1, heightInPixels2, widthInBytes1, widthInBytes2));
                }

                Tuple<int, int, int> outp;

                Parallel.For(0, heightInPixels1, y =>
                {
                    byte* currentLine1 = PtrFirstPixel1 + (y * bitmapData1.Stride);
                    byte* currentLine2 = PtrFirstPixel2 + (y * bitmapData2.Stride);
                    for (int x = 0; x < widthInBytes1; x = x + bytesPerPixel1)
                    {
                        int oldBlue1 = currentLine1[x];
                        int oldGreen1 = currentLine1[x + 1];
                        int oldRed1 = currentLine1[x + 2];
                        int oldBlue2 = currentLine2[x];
                        int oldGreen2 = currentLine2[x + 1];
                        int oldRed2 = currentLine2[x + 2];

                        outp = op(oldRed1, oldRed2, oldGreen1, oldGreen2, oldBlue1, oldBlue2);

                        currentLine1[x] = (byte)outp.Item3;//blue
                        currentLine1[x + 1] = (byte)outp.Item2;//green
                        currentLine1[x + 2] = (byte)outp.Item1;//red
                    }
                });
                bitmap1.UnlockBits(bitmapData1);
                bitmap2.UnlockBits(bitmapData2);
            }
        }

        /// <summary>
        /// perform operation op on each bit of the image. Uses Lockbits and parallel execution CHANGES MADE IN OUTPUTTED BITMAP
        /// </summary>
        /// <param name="processedBitmap"></param>
        /// <param name="op"></param>
        public static Bitmap DeriveImage(Bitmap processedBitmap, Operation op)
        {
            unsafe
            {
                Bitmap output = processedBitmap;
                BitmapData bitmapData = processedBitmap.LockBits(new Rectangle(0, 0, processedBitmap.Width, processedBitmap.Height), ImageLockMode.ReadWrite, processedBitmap.PixelFormat);
                BitmapData bitmapDataOUT = output.LockBits(new Rectangle(0, 0, processedBitmap.Width, processedBitmap.Height), ImageLockMode.ReadWrite, processedBitmap.PixelFormat);

                int bytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(processedBitmap.PixelFormat) / 8;
                int heightInPixels = bitmapData.Height;
                int widthInBytes = bitmapData.Width * bytesPerPixel;
                byte* PtrFirstPixel = (byte*)bitmapData.Scan0;
                byte* PtrFirstPixelOUTPUT = (byte*)bitmapDataOUT.Scan0;
                Tuple<int, int, int> outp;

                Parallel.For(0, heightInPixels, y =>
                {
                    byte* currentLineOUTPUT = PtrFirstPixelOUTPUT + (y * bitmapData.Stride);
                    byte* currentLine = PtrFirstPixel + (y * bitmapData.Stride);
                    for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                    {
                        int oldBlue = currentLine[x];
                        int oldGreen = currentLine[x + 1];
                        int oldRed = currentLine[x + 2];

                        outp = op(oldRed, oldGreen, oldBlue);

                        currentLineOUTPUT[x] = (byte)outp.Item3;//blue
                        currentLineOUTPUT[x + 1] = (byte)outp.Item2;//green
                        currentLineOUTPUT[x + 2] = (byte)outp.Item1;//red
                    }
                });
                processedBitmap.UnlockBits(bitmapData);
                output.UnlockBits(bitmapDataOUT);
                return output;
            }
        }
    }
}