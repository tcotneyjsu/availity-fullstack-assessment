using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("AvailityAssessmentTest")]

namespace AvailityCSharpAssessment
{
    internal static class Utilities
    {
        /// <summary>
        /// Reads a CSV file into a list of lines.
        /// </summary>
        /// <param name="filePath">Path to CSV file to read.</param>
        /// <returns>List of lines read from the CSV file.</returns>
        /// <exception cref="Exception">File Path is invalid.</exception>
        internal static List<string> ReadCSVFile(string filePath)
        {
            // TODO: Potentially benchmark some readline methods
            List<string> csvLines = new List<string>();

            if (File.Exists(filePath))
            {
                foreach (string line in File.ReadAllLines(filePath))
                {
                    csvLines.Add(line);
                }
            }
            else throw new Exception("File Path is invalid.");

            return csvLines;
        }
    }
}
