using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JabilTest;
namespace EmguCV_FunctionCustom
{
    class ArrayContains : JabilTest.Test
    {
        public ArrayContains(ScriptVariableSpace varSpace, object testParams) : base(varSpace, (object)null) {}

        public override string Version
        {
            get
            {
                return "1.00.00";
            }
        }

        public override TestResult Execute()
        {
            bool RESULT = false;
            TestResult testResult = this.testResult;
            testResult.TestName = this.Name;
            testResult.TestDescription = this.Description;
            testResult.Status = TestStatus.Running;
            Array arrayVariable = this.GetArrayVariable("Argument0", "Array");
            string objectVariable = this.GetObjectVariable("Argument1", "Search Element").ToString();
            if (arrayVariable.Rank != 1)
            {
                this.FailTest(string.Format("Array1DContains: Invalid # of dimensions in input array - [{0}]. Array must be 1D.", (object)arrayVariable.Rank));
                return testResult;
            }


            string[] _Array = arrayVariable.OfType<object>().Select(o => o.ToString()).ToArray();

            foreach(string str in _Array)
            {
                if (str.Contains(objectVariable))
                {
                    RESULT = true;
                    break;
                }           
            }

            this.VariableSpace.setVariable(new ScriptVariable("ReturnValue0", VariableType.Boolean, RESULT));
            testResult.Status = TestStatus.Pass;
            return testResult;
        }
    }
}
