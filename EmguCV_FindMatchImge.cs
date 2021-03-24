using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JabilTest;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using System.Windows.Forms;

namespace EmguCV_FunctionCustom
{
    public class EmguCV_FindMatchImge : JabilTest.Test
    {
        public EmguCV_FindMatchImge(ScriptVariableSpace varSpace, object otherParameters) : base(varSpace, otherParameters){}


        EmguCV_FindMatchImageViewer _FindMatchImageViewer;

        public override TestResult Execute()
        {
            string CAMERA_NUMBER = this.GetObjectVariable("Argument0", "Name0").ToString().Replace("'", "");
            string ROI_X = this.GetObjectVariable("Argument1", "Name1").ToString().Replace("'", "");
            string ROI_Y = this.GetObjectVariable("Argument2", "Name2").ToString().Replace("'", "");
            string ROI_Width = this.GetObjectVariable("Argument3", "Name3").ToString().Replace("'", "");
            string ROI_Height = this.GetObjectVariable("Argument4", "Name4").ToString().Replace("'", "");
            string IMG_REF = this.GetObjectVariable("Argument5", "Name5").ToString().Replace("'", "");
            string FIND_MATCH_SCORE = this.GetObjectVariable("Argument6", "Name6").ToString().Replace("'", "");
            string CONFIDENCE = this.GetObjectVariable("Argument7", "Name7").ToString().Replace("'", "");
            string TIMETOFAIL = this.GetObjectVariable("Argument8", "Name8").ToString().Replace("'", "");
            string DEBUG = this.GetObjectVariable("Argument9", "Name9").ToString().Replace("'", "");

            try
            {
                _FindMatchImageViewer = new EmguCV_FindMatchImageViewer(Convert.ToInt32(CAMERA_NUMBER),
                          Convert.ToInt32(ROI_X),
                          Convert.ToInt32(ROI_Y),
                          Convert.ToInt32(ROI_Width),
                          Convert.ToInt32(ROI_Height),
                          IMG_REF,
                          Convert.ToDouble(FIND_MATCH_SCORE),
                          Convert.ToInt32(CONFIDENCE),
                          Convert.ToInt16(TIMETOFAIL),
                          Convert.ToBoolean(DEBUG));

                DialogResult dr = new DialogResult();
                dr = _FindMatchImageViewer.ShowDialog();             
                _FindMatchImageViewer.Close();

                if(dr == DialogResult.Abort)
                {
                    this.FailTest("Fail");
                    return testResult;
                }
            }
            catch(Exception ex)
            {
                this.FailTest(ex.Message);
                return testResult;
            }
  
            ScriptVariable retVar0 = new ScriptVariable("ReturnValue0", VariableType.Object, _FindMatchImageViewer._ImageEvidence);
            ScriptVariable retVar1 = new ScriptVariable("ReturnValue1", VariableType.Float, _FindMatchImageViewer._ConfidenceScore);
            VariableSpace.setVariable(retVar0);
            VariableSpace.setVariable(retVar1);
            testResult.Status = TestStatus.Pass;
            return testResult;
        }
    }
}
