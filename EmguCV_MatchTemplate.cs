using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using JabilTest;

namespace EmguCV_FunctionCustom
{
    class EmguCV_MatchTemplate : JabilTest.Test
    {
        public EmguCV_MatchTemplate(ScriptVariableSpace varSpace, object otherParameters) : base(varSpace, otherParameters) { }

        EmguCV_MatchTemplateViewer _MatchImageViewer;

        public override TestResult Execute()
        {
            object SEARCH_IMAGE = this.GetObjectVariable("Argument0", "Search Image");
            object TEMPLATE_IMAGE = this.GetObjectVariable("Argument1", "Template Image");
            string MATCHING_ALGORITHM = this.GetStringVariable("Argument2", "Matching Algorithm").ToUpper();
            double MATCH_SCORE = this.GetFloatVariable("Argument3", "Matching Score");
            bool DEBUG = this.GetBooleanVariable("Argument4", "Debug Mode");

            try
            {
                _MatchImageViewer = new EmguCV_MatchTemplateViewer(SEARCH_IMAGE, TEMPLATE_IMAGE, MATCHING_ALGORITHM, MATCH_SCORE,DEBUG);
                DialogResult dr = new DialogResult();
                dr = _MatchImageViewer.ShowDialog();
            }
            catch(Exception ex)
            {
                this.FailTest(ex.Message);
                return testResult;
            }

            ScriptVariable retVar0 = new ScriptVariable("ReturnValue0", VariableType.Object, _MatchImageViewer._ImageEvidence);
            ScriptVariable retVar1 = new ScriptVariable("ReturnValue1", VariableType.Float, _MatchImageViewer._ConfidenceScore);
            VariableSpace.setVariable(retVar0);
            VariableSpace.setVariable(retVar1);
            testResult.Status = TestStatus.Pass;
            return testResult;
        }
    }
}
