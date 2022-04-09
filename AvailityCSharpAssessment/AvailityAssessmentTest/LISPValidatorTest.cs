using Microsoft.VisualStudio.TestTools.UnitTesting;
using AvailityCSharpAssessment;

namespace AvailityAssessmentTest
{
    [TestClass]
    public class LISPValidatorTest
    {
        [TestMethod]
        public void LISPParenthesesChecker_Test_Correct()
        {
            // String pulled from an example on the Lisp wikipedia page
            string lispCode = "((lambda (arg) (+ arg 1)) 5)";
            Assert.IsTrue(LISPCodeValidator.LISPParenthesesChecker(lispCode));
        }
        [TestMethod]
        public void LISPParenthesesChecker_Test_MultiLine_Correct()
        {
            // String pulled from an example on the Lisp wikipedia page
            string lispCode = "((lambda (arg) (+ arg 1)) 5)(or (and \"zero\" nil \"never\") \"James\" 'task 'time)(setf (fdefinition 'f) #'(lambda (a) (block f b...)))";
            Assert.IsTrue(LISPCodeValidator.LISPParenthesesChecker(lispCode));
        }
        [TestMethod]
        public void LISPParenthesesChecker_Test_TooManyOpenParens()
        {
            string lispCode = "((lambda ((arg) (+ arg 1)) 5)";
            Assert.IsFalse(LISPCodeValidator.LISPParenthesesChecker(lispCode));
        }
        [TestMethod]
        public void LISPParenthesesChecker_Test_TooManyClosedParens()
        {
            // String pulled from an example on the Lisp wikipedia page
            string lispCode = "((lambda (arg)) (+ arg 1)) 5)";
            Assert.IsFalse(LISPCodeValidator.LISPParenthesesChecker(lispCode));
        }
        [TestMethod]
        public void LISPParenthesesChecker_Test_ExtraOpenAtEnd()
        {
            string lispCode = "((lambda (arg) (+ arg 1)) 5)(";
            Assert.IsFalse(LISPCodeValidator.LISPParenthesesChecker(lispCode));
        }
        [TestMethod]
        public void LISPParenthesesChecker_Test_ExtraClosedAtEnd()
        {
            string lispCode = "((lambda (arg) (+ arg 1)) 5))";
            Assert.IsFalse(LISPCodeValidator.LISPParenthesesChecker(lispCode));
        }
        [TestMethod]
        public void LISPParenthesesChecker_Test_ExtraOpenAtBeginning()
        {
            // String pulled from an example on the Lisp wikipedia page
            string lispCode = "(((lambda (arg) (+ arg 1)) 5)";
            Assert.IsFalse(LISPCodeValidator.LISPParenthesesChecker(lispCode));
        }
        [TestMethod]
        public void LISPParenthesesChecker_Test_ExtraClosedAtBeginning()
        {
            // String pulled from an example on the Lisp wikipedia page
            string lispCode = ")((lambda (arg) (+ arg 1)) 5)";
            Assert.IsFalse(LISPCodeValidator.LISPParenthesesChecker(lispCode));
        }
    }
}