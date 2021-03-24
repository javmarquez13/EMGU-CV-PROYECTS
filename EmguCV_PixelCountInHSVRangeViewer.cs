using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace EmguCV_FunctionCustom
{
    public partial class EmguCV_PixelCountInHSVRangeViewer : Form
    {
        IImage _ImageQueryFrame;
        double _Min_H, _Min_S, _Min_V, _Max_H, _Max_S, _Max_V;
        int _Roi_X, _Roi_Y, _Roi_Width, _Roi_Heigth;
        bool _Debug;


        public EmguCV_PixelCountInHSVRangeViewer(object ImageQueryFrame, double Min_H, double Min_S, double Min_V, double Max_H, double Max_S, double Max_V, int Roi_X, int Roi_Y, int Roi_Width, int Roi_Heigth, bool Debug)
        {
            InitializeComponent();

            _ImageQueryFrame = (IImage)ImageQueryFrame;
            _Min_H = Min_H;
            _Min_S = Min_S;
            _Min_V = Min_V;
            _Max_H = Max_H;
            _Max_S = Max_S;
            _Max_V = Max_V;
            _Roi_X = Roi_X;
            _Roi_Y = Roi_Y;
            _Roi_Width = Roi_Width;
            _Roi_Heigth = Roi_Heigth;
            _Debug = Debug;
        }

        public Image<Bgr,byte> _ImageEvidence { get; set; }
        public double _PixelCount { get; set; }


        private void EmguCV_PixelCountInHSVRangeViewer_Load(object sender, EventArgs e)
        {
            PixelCount();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        void PixelCount()
        {
             double num1 = _Min_H / 2.0;
             double num2 = _Max_H / 2.0;
             double num3 = _Min_S / 100.0 * byte.MaxValue;
             double num4 = _Max_S / 100.0 * byte.MaxValue;
             double num5 = _Min_V / 100.0 * byte.MaxValue;
             double num6 = _Max_V / 100.0 * byte.MaxValue;

            Image<Hsv, byte> _image1 = null;
            Image<Hsv, byte> _image2 = null;
            IImage _image3 = _ImageQueryFrame;

            _image2 = new Image<Hsv, byte>(_image3.Bitmap);
            _image1 = _image2.Copy();

            int _TempPixelCountScore = 0;
            Hsv _hsv1 = new Hsv();
            Hsv _hsv2 = new Hsv(120.0, byte.MaxValue, byte.MaxValue);


            for (int index1 = _Roi_Y; index1 < _Roi_Heigth; ++index1)
            {
                for (int index2 = _Roi_X; index2 < _Roi_Width; ++index2)
                {
                    Hsv hsv3 = _image2[index1, index2];
                    if (hsv3.Value >= num5 && hsv3.Value <= num6 && (hsv3.Satuation >= num3 && hsv3.Satuation <= num4))
                    {
                        if (num1 > num2)
                        {
                            if (hsv3.Hue >= num1 || hsv3.Hue <= num2)
                            {
                                ++_TempPixelCountScore;
                                _image1[index1, index2] = _hsv2;
                            }
                        }
                        else if (hsv3.Hue >= num1 && hsv3.Hue <= num2)
                        {
                            ++_TempPixelCountScore;
                            _image1[index1, index2] = _hsv2;
                        }
                    }
                }
            }

          
            int width = _Roi_Width - _Roi_X;
            int height = _Roi_Heigth - _Roi_Y;
            Rectangle rect = new Rectangle(_Roi_X, _Roi_Y, width, height);
            _image1.Draw(rect, new Hsv(0, 255, byte.MaxValue), 2, LineType.AntiAlias, 0);

            pbQueryFrame.Image = _ImageQueryFrame.Bitmap;
            pbPixelCount.Image = _image1.Bitmap;
            _PixelCount = _TempPixelCountScore;
            lblPixelCountScore.Text = "Pixel Count Score: " + _PixelCount.ToString();
            this.Refresh();

            Bitmap bmp = new Bitmap(this.Width, this.Height);
            DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            _ImageEvidence = new Image<Bgr,byte>(bmp);

            if (!_Debug) timer.Start();
        }
    }
}
