using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using JabilTest;

namespace EmguCV_FunctionCustom
{
    class EmguCV_QueryFrame : JabilTest.Test
    {
        public EmguCV_QueryFrame(ScriptVariableSpace varSpace, object otherParameters) : base(varSpace, otherParameters) { }

        public override TestResult Execute()
        {
            object _varRet = null;
            int CAMERA_NUMBER = this.GetIntegerVariable("Argument0", "Name0");
            int WIDTH = this.GetIntegerVariable("Argument1", "Name1");
            int HEIGTH = this.GetIntegerVariable("Argument2", "Name2");


            try
            {
                _varRet = QueryFrame(CAMERA_NUMBER, WIDTH, HEIGTH);
            }
            catch (Exception ex)
            {
                _varRet = ex.Message;
                this.FailTest(ex.Message);
                return testResult;
            }

            ScriptVariable retVar0 = new ScriptVariable("ReturnValue0", VariableType.Object, _varRet);
            VariableSpace.setVariable(retVar0);
            testResult.Status = TestStatus.Pass;
            return testResult;
        }



     
        Image<Bgr, byte> QueryFrame(int CameraNum, int SWidth, int SHeigth)
        {
            Image<Bgr, byte> _imageCV = null;
            VideoCapture _VideoCapture = new VideoCapture(CameraNum);
            _VideoCapture.SetCaptureProperty(CapProp.Autofocus, 39);
            _VideoCapture.SetCaptureProperty(CapProp.AutoExposure, 21);
            ICapture _Capture = _VideoCapture as ICapture;
            Mat _ImgMat = _Capture.QueryFrame();
            _ImgMat = _Capture.QueryFrame();
            _imageCV = new Image<Bgr, byte>(_ImgMat.Bitmap);
            _imageCV = _imageCV.Resize(SWidth, SHeigth, Inter.Linear);
            _VideoCapture.Dispose();
            return _imageCV;
        }
    }
}
