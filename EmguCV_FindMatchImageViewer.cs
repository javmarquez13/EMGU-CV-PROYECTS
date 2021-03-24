using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Threading;
using System.IO;
using System.Drawing.Drawing2D;
using System.Collections.Generic;

/// <summary>
/// 
/// 02 Febrero 2021
/// First Relase by Francisco Javier Marquez
/// 1.0.0.0
/// 
/// 
/// 02 Febrero 2021
/// Fix Crash Application Error when try to draw the rectangle ROI
/// 1.0.0.1
/// 
///
/// 
/// 
/// </summary>
namespace EmguCV_FunctionCustom
{

    public partial class EmguCV_FindMatchImageViewer : Form
    {
        #region Variables from Jabil Test

        VideoCapture _VideoCapture;
        int ROI_X;
        int ROI_Y;
        int ROI_Width;
        int ROI_Height;
        string ImgRef;
        double FindMatchScore;
        int _Confidence;
        int _Timetofail;
        bool _Debug;

        #endregion

        #region Variables Globales

        string _Version = "FIND MATCH IMAGE v1.0.0.1";
        Image<Hsv, byte> imgQueryFrame = null;
        ICapture _Capture;
        int _CountConfidence = 0;
        public double _ConfidenceScore { get; set; }
        Point _StartROI, _EndROI;
        Rectangle _RecROI;
        bool _DrawRectangle = false;
        int _RecROIWidth;
        int _RecROIheigth;
        int _RealWidth;
        int _RealHeigth;
        string[] _CodeJabilTest = new string[4];
        Mat _ImgMat;
        Image<Hsv, byte> imgCorpROI1;
        int _secondcount = 0;

        #endregion


        public EmguCV_FindMatchImageViewer(int CAMERA, int ROIX, int ROIY, int ROIWidth, int ROIHeight, string ImgReference, double MatchScore, int Confidence,int Timetofail, bool Debug)
        {
            InitializeComponent();
            Application.Idle += new EventHandler(Capture);
            _VideoCapture = new VideoCapture(CAMERA);
            _VideoCapture.SetCaptureProperty(CapProp.Autofocus, 39);
            _VideoCapture.SetCaptureProperty(CapProp.AutoExposure, 21);
            _Capture = _VideoCapture as ICapture;
            Timer.Start();
            TIMETOFAIL.Start();
            ROI_X = ROIX;
            ROI_Y = ROIY;
            ROI_Width = ROIWidth;
            ROI_Height = ROIHeight;
            ImgRef = ImgReference;
            FindMatchScore = MatchScore;
            _Confidence = Confidence;
            _Timetofail = Timetofail;
            _Debug = Debug;
            RoundApp();
        }


        public Image<Bgr,byte> _ImageEvidence { get; set; }

        void RoundApp()
        {
            Rectangle r = new Rectangle(0, 0, pbOriginal.Width, pbOriginal.Height);
            GraphicsPath gp = new GraphicsPath();
            int d = 10;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            pbOriginal.Region = new Region(gp);

            r = new Rectangle(0, 0, pbROI.Width, pbROI.Height);
            gp = new GraphicsPath();
            d = 10;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            pbROI.Region = new Region(gp);

            r = new Rectangle(0, 0, btnExit.Width, btnExit.Height);
            gp = new GraphicsPath();
            d = 20;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            btnExit.Region = new Region(gp);
        }

        void Capture(object sender, EventArgs e)
        {
            try
            {
                _ImgMat = _Capture.QueryFrame();
            }
            catch { };
        }

        void FindMatchImage()
        {
            try
            {
                imgQueryFrame = new Image<Hsv, byte>(_ImgMat.Bitmap);

                int _height = imgQueryFrame.Height;
                int _width = imgQueryFrame.Width;
                _RealWidth = imgQueryFrame.Width;
                _RealHeigth = imgQueryFrame.Height;

                lblWidth.Text = "Width: " +_width.ToString();
                lblHeight.Text = "Heigth: "+ _height.ToString();

                Rectangle ROI = new Rectangle(ROI_X, ROI_Y, ROI_Width, ROI_Height);

                imgQueryFrame.Draw(ROI, new Hsv(0, 255, byte.MaxValue), 2, LineType.AntiAlias, 0);

                imgCorpROI1 = null;
                imgCorpROI1 = imgQueryFrame.Copy();
                imgCorpROI1.ROI = ROI;

                lblCorpWidth.Text = "Width: " + imgCorpROI1.Width;
                lblCorpHeigth.Text = "Heigth: " + imgCorpROI1.Height;

                Image<Hsv, byte> source = imgCorpROI1.Copy();
                Image<Hsv, byte> template = new Image<Hsv, byte>(ImgRef);
                Image<Hsv, byte> imageToShow = imgCorpROI1.Copy();

                pbOriginal.Image = imgQueryFrame.Bitmap; 
                pbROI.Image = imgCorpROI1.Bitmap;

                using (Image<Gray, float> result = source.MatchTemplate(template, TemplateMatchingType.CcoeffNormed))               
                {
                    double[] minValues, maxValues;
                    Point[] minLocations, maxLocations;
                    result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);
                    _ConfidenceScore = maxValues[0];
                    lblFindMatchScore.Text = "Find Match Score: " + _ConfidenceScore;

                    if (maxValues[0] > FindMatchScore)
                    {
                        Rectangle match = new Rectangle(maxLocations[0], template.Size);

                        imageToShow.Draw(match, new Hsv(0, 255, (double)byte.MaxValue), 3);
                        pbROI.Image = imageToShow.Bitmap;
                        lblFindMatchScore.Text = "Find Match Score: " + maxValues[0].ToString();
                        _CountConfidence++;
                        lblConfidence.Text = "Confidence: " + _CountConfidence.ToString();
                    }
                    else
                    {
                        _CountConfidence = 0;
                        lblConfidence.Text = "Confidence: " + _CountConfidence.ToString();
                    }
                }

                if (!_Debug)
                {
                    if (_CountConfidence >= _Confidence)
                    {
                        Bitmap bmp = new Bitmap(this.Width, this.Height);
                        DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                        _ImageEvidence = new Image<Bgr,byte>(bmp);

                        DialogResult = DialogResult.OK;
                        Timer.Stop();
                    }
                }               
            }
            catch(Exception ex)
            {
                lblError.Text = "ErrorMessage: " + ex.Message;
            }         
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Capture(sender, e);
            FindMatchImage();
            this.Refresh();
        }

        private void pbOriginal_MouseDown(object sender, MouseEventArgs e)
        {
            if (_Debug)
            {
                _StartROI = e.Location;
                _DrawRectangle = true;
            }     
        }

        private void pbOriginal_MouseMove(object sender, MouseEventArgs e)
        {
            if (_Debug)
            { 
                try
                {
                    var wfactor = (double)_RealWidth / pbOriginal.ClientSize.Width;
                    var hfactor = (double)_RealHeigth / pbOriginal.ClientSize.Height;
                    //var hfactor = (double)_RealHeigth / 280;

                    var resizeFactor = Math.Max(wfactor, hfactor);
                    var imageSize = new Size((int)(_RealWidth / resizeFactor), (int)(_RealHeigth / hfactor));

                    int width = Convert.ToInt16((double)e.X / resizeFactor);
                    int heigth = Convert.ToInt16((double)e.Y / resizeFactor);

                    _RecROIWidth = Math.Max(_StartROI.X, e.X) - Math.Min(_StartROI.X, e.X);
                    _RecROIheigth = Math.Max(_StartROI.Y, e.Y) - Math.Min(_StartROI.Y, e.Y);

                    _RecROI = new Rectangle(Math.Min(_StartROI.X, e.X), Math.Min(_StartROI.Y, e.Y), _RecROIWidth, _RecROIheigth);

                    if (!_DrawRectangle)
                    {
                        string ROI_X_CODE = "$ROI_X = " + Math.Round(e.X * wfactor);
                        string ROI_Y_CODE = "$ROI_Y = " + Math.Round(e.Y * hfactor);

                        _CodeJabilTest[0] = ROI_X_CODE;
                        _CodeJabilTest[1] = ROI_Y_CODE;
                    }

                    if (_DrawRectangle)
                    {
                        string ROI_WIDTH_CODE = "$ROI_Width = " + Math.Round(_RecROIWidth * wfactor).ToString();
                        string ROI_HEIGTH_CODE = "$ROI_Height = " + Math.Round(_RecROIheigth * hfactor).ToString();

                        _CodeJabilTest[2] = ROI_WIDTH_CODE;
                        _CodeJabilTest[3] = ROI_HEIGTH_CODE;
                    }
                }
                catch (Exception ex)
                {
                    lblError.Text = ex.Message;
                }
                Refresh();
            }       
        }

        private void pbOriginal_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (_Debug)
                {
                    rBoxCode.Text = string.Empty;
                    _DrawRectangle = false;
                    foreach (string _Code in _CodeJabilTest)
                    {
                        rBoxCode.AppendText(_Code + ";\n");
                    }

                    Timer.Stop();
                    ROI_X = Convert.ToInt16(_CodeJabilTest[0].Replace(" ", "").Split('=')[1]);
                    ROI_Y = Convert.ToInt16(_CodeJabilTest[1].Replace(" ", "").Split('=')[1]);
                    ROI_Width = Convert.ToInt16(_CodeJabilTest[2].Replace(" ", "").Split('=')[1]);
                    ROI_Height = Convert.ToInt16(_CodeJabilTest[3].Replace(" ", "").Split('=')[1]);

                    FindMatchImage();
                    this.Refresh();

                    if (!Directory.Exists(@"C:\Images\")) Directory.CreateDirectory(@"C:\Images\");
                    imgCorpROI1.Bitmap.Save(@"C:\Images\CorpROI.JPG");
                    Timer.Start();

                }
            }
            catch(Exception ex) { lblError.Text = ex.Message; };        
        }

        private void TIMETOFAIL_Tick(object sender, EventArgs e)
        {
            if (_Debug) return;
            if (_secondcount >= _Timetofail)
            {
                
                Timer.Stop();
                TIMETOFAIL.Stop();
                DialogResult = DialogResult.Abort;
            }
            _secondcount++;
        }

        private void EmguCV_FindMatchImageViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            //_VideoCapture.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }

        private void pbOriginal_Paint(object sender, PaintEventArgs e)
        {
            if (_DrawRectangle)
            {
                using (Pen pen = new Pen(Color.Red, 3))
                {
                    e.Graphics.DrawRectangle(pen, _RecROI);
                }
            }         
        }
    }
}
