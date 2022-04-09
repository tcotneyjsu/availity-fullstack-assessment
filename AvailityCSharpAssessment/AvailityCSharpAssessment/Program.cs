namespace AvailityCSharpAssessment
{
    class Program
    {
        //Adding a temp start point for testing
        static void Main(string[] args)
        {
            Console.WriteLine("Program Start!");
            // String pulled from an example on the Lisp wikipedia page
            string lispCode = "((lambda (arg) (+ arg 1)) 5)";
            LISPCodeValidator.LISPParenthesesChecker(lispCode);
        }
    }
}