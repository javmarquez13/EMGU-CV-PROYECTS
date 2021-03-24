using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmguCV_FunctionCustom
{
    public partial class EmguCV_MatchTemplateViewer : Form
    {
        Image<Bgr, byte> _SearchImage = null;
        Image<Bgr, byte> _TemplateImg = null;
        string _MatchAlgoritmh = string.Empty;
        double _MatchTemplateScore;
        bool _Debug = false;
     
        public EmguCV_MatchTemplateViewer(object SearchImage, object TemplateImg, string MatchAlgoritmh, double MatchScore, bool Debug)
        {
            InitializeComponent();
            _SearchImage = SearchImage as Image<Bgr, byte>;
            _TemplateImg = TemplateImg as Image<Bgr, byte>;
            _MatchAlgoritmh = MatchAlgoritmh;
            _MatchTemplateScore = MatchScore;
            _Debug = Debug;
        }


        TemplateMatchingType method;
        public double _ConfidenceScore { get; set; }
        //public Bitmap _ImageEvidence { get; set; }
        public Image<Bgr,byte> _ImageEvidence { get; set; }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }

        private void EmguCV_MatchTemplateViewer_Load(object sender, EventArgs e)
        {
            Image<Bgr, byte> imageToShow = _TemplateImg.Copy();

            if (_MatchAlgoritmh == "CCOEFF_NORMALIZED") method = TemplateMatchingType.CcoeffNormed;
            if (_MatchAlgoritmh == "CCORR_NORMALIZED") method = TemplateMatchingType.CcorrNormed;
            if (_MatchAlgoritmh == "SQDIFF_NORMALIZED") method = TemplateMatchingType.SqdiffNormed;


            using (Image<Gray, float> result = _SearchImage.MatchTemplate(_TemplateImg, method))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);
                _ConfidenceScore = maxValues[0];
                lblFindMatchScore.Text = "Find Match Score: " + _ConfidenceScore;

                if (maxValues[0] > _MatchTemplateScore)
                {
                    Rectangle match = new Rectangle(maxLocations[0], _TemplateImg.Size);

                    imageToShow.Draw(match, new Bgr(0, 255, (double)byte.MaxValue), 3);
                    pbSearchImage.Image = _SearchImage.Bitmap;
                    pbTemplate.Image = imageToShow.Bitmap;
                    lblFindMatchScore.Text = "Match Score: " + maxValues[0].ToString();
                 
                    Bitmap bmp = new Bitmap(this.Width, this.Height);
                    DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    _ImageEvidence = new Image<Bgr, byte>(bmp);
                }
            }

            if (!_Debug) Timer.Start();
            this.Refresh();          
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
