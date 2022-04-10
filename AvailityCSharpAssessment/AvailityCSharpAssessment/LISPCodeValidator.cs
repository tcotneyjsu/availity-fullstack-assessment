using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("AvailityAssessmentTest")]

namespace AvailityCSharpAssessment
{
    internal static class LISPCodeValidator
    {
        /// <summary>
        /// This function checks the parentheses of a LISP code and 
        /// validates that the parentheses are properly closed and nested.
        /// </summary>
        /// <param name="lispCode">String of code to be checked.</param>
        /// <returns>True if all the parentheses are properly close and nested.</returns>
        internal static bool LISPParenthesesChecker(string lispCode)
        {
            int openParensCount = 0;
            foreach(char i in lispCode)
            {
                if (i == '(')
                {
                    openParensCount++;
                }
                if (i == ')')
                {
                    openParensCount--;
                }
                // If too many Closed parentheses are detected, we can return false.
                if (openParensCount < 0)
                {
                    return false;
                }
            }
            // If openParensCount is 0 at the end of the for loop,
            // then all open parentheses have a matching closed parentheses
            // If openParensCount is > 0, then there is a loose open parentheses
            // If openParensCount is < 0, then there is a loose closed parentheses
            return openParensCount == 0;
        }
    }
}
