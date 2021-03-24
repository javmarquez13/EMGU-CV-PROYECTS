using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Basler.Pylon;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using JabilTest;

namespace EmguCV_FunctionCustom
{
    class EmguCV_BPQueryFrame : Test
    {
        public EmguCV_BPQueryFrame(ScriptVariableSpace varSpace, object otherParameters) : base(varSpace, otherParameters) { }

        public override TestResult Execute()
        {
            object _varRet = null;
            int CAMERA_NUMBER = this.GetIntegerVariable("Argument0", "Name0");
            int WIDTH = this.GetIntegerVariable("Argument1", "Name1");
            int HEIGTH = this.GetIntegerVariable("Argument2", "Name2");
            
            try
            {
               _varRet = QueryFrameBP(CAMERA_NUMBER, WIDTH, HEIGTH);
            }
            catch(Exception ex)
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

        PixelDataConverter converter = new PixelDataConverter();


        Image<Bgr, byte> QueryFrameBP(int CameraNum, int SWidth, int SHeigth)
        {
            string Resultado = string.Empty;
            Camera _Camera = null;
            Image<Bgr, byte> _imageCV = null;

            List<ICameraInfo> _cameras = new List<ICameraInfo>();
            _cameras = CameraFinder.Enumerate();

            string _CameraModelName = _cameras[CameraNum][CameraInfoKey.ModelName];
            _Camera = new Camera(_cameras[CameraNum]);

            _Camera.CameraOpened += Configuration.AcquireContinuous;

            _Camera.Open();

            _Camera.Parameters[PLCameraInstance.MaxNumBuffer].SetValue(5);

            _Camera.StreamGrabber.Start();

            IGrabResult grabResult = _Camera.StreamGrabber.RetrieveResult(5000, TimeoutHandling.ThrowException);

            if (grabResult.GrabSucceeded)
            {
                Bitmap _tempImg = GrabResult2Bmp(grabResult);
                _imageCV = new Image<Bgr, byte>(_tempImg);
                _imageCV = _imageCV.Resize(SWidth, SHeigth, Inter.Linear);          
                _Camera.StreamGrabber.Stop();
                _Camera.Close();
                _Camera.Dispose();
            }

            if (!grabResult.GrabSucceeded)
            {
                _Camera.StreamGrabber.Stop();
                _Camera.Close();
                _Camera.Dispose();
            }
            return _imageCV;
        }


        Bitmap GrabResult2Bmp(IGrabResult grabResult)
        {
            //using (Bitmap b = new Bitmap(grabResult.Width, grabResult.Height, PixelFormat.Format32bppRgb))
            //{
            Bitmap b = new Bitmap(grabResult.Width, grabResult.Height, PixelFormat.Format32bppRgb);
            BitmapData bmpData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, b.PixelFormat);
            converter.OutputPixelFormat = PixelType.BGRA8packed;
            IntPtr bmpIntpr = bmpData.Scan0;
            converter.Convert(bmpIntpr, bmpData.Stride * b.Height, grabResult);
            b.UnlockBits(bmpData);
            return b;
            //}
        }


        Image<Bgr, byte> QueryFrame(int CameraNum, int SWidth, int SHeigth)
        {
            Camera _Camera = null;
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
