using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JabilTest;

namespace EmguCV_FunctionCustom
{
    class UpdateStatusTryCatch : JabilTest.Test
    {
        public UpdateStatusTryCatch(ScriptVariableSpace varSpace, object otherParameters) : base(varSpace, otherParameters) { }

        public override string Version
        {
            get
            {
                return "1.00.00";
            }
        }

        public override bool Validated
        {
            get
            {
                return true;
            }
        }

        public override string ValidatedBy
        {
            get
            {
                return "By Fco Javier Marquez";
            }
        }

        public override DateTime? ValidationDate
        {
            get
            {
                return new DateTime?(new DateTime(2012, 3, 7));
            }
        }



        public override TestResult Execute()
        {
            TestResult testResult = this.testResult;
            testResult.TestName = this.Name;
            testResult.TestDescription = this.Description;

            string stringVariable = "Null";

            try
            {
                stringVariable = this.GetStringVariable("Argument0", "Update String");
            }
            catch(Exception EX)
            {
                
            }

     
            this.VariableSpace.UpdateStatusTextFromUpdateStatus(stringVariable);
            testResult.strMeasurement = stringVariable;
            testResult.Status = TestStatus.Pass;
            return testResult;
        }
    }
}
