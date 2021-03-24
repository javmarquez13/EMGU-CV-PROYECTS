using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JabilTest;
using Emgu.CV;
using Emgu.CV.Structure;

namespace EmguCV_FunctionCustom
{
    class EmguCV_PixelCountInHSVRange : JabilTest.Test
    {
        public EmguCV_PixelCountInHSVRange(ScriptVariableSpace varSpace, object otherParameters) : base(varSpace, otherParameters) { }


        EmguCV_PixelCountInHSVRangeViewer _EmguCV_PixelCountInHSVRangeViewer;

        public override TestResult Execute()
        {
            object QUERY_FRAME = this.GetObjectVariable("Argument0", "Query Frame");
            double MIN_H = this.GetFloatVariable("Argument1", "Min Value for Hue");
            double MIN_S = this.GetFloatVariable("Argument2", "Min Value for Saturation");
            double MIN_V = this.GetFloatVariable("Argument3", "Min Value for Value");
            double MAX_H = this.GetFloatVariable("Argument4", "Max Value for Hue");
            double MAX_S = this.GetFloatVariable("Argument5", "Max Value for Saturation");
            double MAX_V = this.GetFloatVariable("Argument6", "Max Value for Value");
            int ROI_X = this.GetIntegerVariable("Argument7", "ROI Point X");
            int ROI_Y = this.GetIntegerVariable("Argument8", "ROI Point Y");
            int ROI_Width = this.GetIntegerVariable("Argument9", "ROI Width");
            int ROI_Heigth = this.GetIntegerVariable("Argument10", "ROI Heigth");
            bool DEBUG = this.GetBooleanVariable("Argument11", "Debug is enable or disable");


            try
            {
              _EmguCV_PixelCountInHSVRangeViewer = new EmguCV_PixelCountInHSVRangeViewer(
              QUERY_FRAME,
              MIN_H,
              MIN_S,
              MIN_V,
              MAX_H,
              MAX_S,
              MAX_V,
              ROI_X,
              ROI_Y,
              ROI_Width,
              ROI_Heigth,
              DEBUG);

              DialogResult _dr = _EmguCV_PixelCountInHSVRangeViewer.ShowDialog();             
            }
            catch(Exception ex)
            {
                this.FailTest(ex.Message);
                return testResult;
            }
      
            ScriptVariable retVar0 = new ScriptVariable("ReturnValue0", VariableType.Object, _EmguCV_PixelCountInHSVRangeViewer._ImageEvidence);
            ScriptVariable retVar1 = new ScriptVariable("ReturnValue1", VariableType.Float, _EmguCV_PixelCountInHSVRangeViewer._PixelCount);
            VariableSpace.setVariable(retVar0);
            VariableSpace.setVariable(retVar1);
            testResult.Status = TestStatus.Pass;
            return testResult;
        }
    }
}
