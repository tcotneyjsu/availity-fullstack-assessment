using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("AvailityAssessmentTest")]

namespace AvailityCSharpAssessment
{
    internal static class EnrollmentFileFormatter
    {
        /// <summary>
        /// Takes a path to an enrollment file and checks they type of the file.
        /// If the file is in csv format, function will format that file.
        /// </summary>
        /// <param name="filePath">Path to enrollment file.</param>
        internal static void FormatEnrollmentFile(string filePath, int expectedColumnCount)
        {
            string extension = Path.GetExtension(filePath);
            if (Path.GetExtension(filePath) == ".csv")
            {
                List<string> fileLines = Utilities.ReadCSVFile(filePath);
                Dictionary<string, List<Enrollment>> separatedByCompany = new Dictionary<string, List<Enrollment>>();
                // Adding a separate dictionary because I had issues iterating through the first dictionary while
                // also trying to modify it in place.
                Dictionary<string, List<Enrollment>> sortedEnrollments = new Dictionary<string, List<Enrollment>>();
                for(int i = 0; i < fileLines.Count; i++)
                {
                    Enrollment enrollment = new Enrollment(fileLines[i]);
                    // Validate that there is the correct amount of information in the line
                    if (enrollment.ColumnCount == expectedColumnCount)
                    {
                        // If company already exist in dictionary
                        if (!separatedByCompany.TryAdd(enrollment.InsuranceCompany,
                            new List<Enrollment>() { enrollment }))
                        {
                            separatedByCompany[enrollment.InsuranceCompany].Add(enrollment);
                        }
                    }
                }
                foreach(KeyValuePair<string, List<Enrollment>> pair in separatedByCompany)
                {
                    // Remove duplicate IDs by greatest version number
                    var temp = separatedByCompany[pair.Key].GroupBy(x => x.UserID).Select(x => x.MaxBy(x => x.Version)).ToList();
                    // Sort Alphabetically
                    temp.Sort((x, y) => x.CompleteName.CompareTo(y.CompleteName));
                    sortedEnrollments.Add(pair.Key, temp);
                    string stringToWrite = "";
                    foreach(Enrollment enrollment in sortedEnrollments[pair.Key])
                    {
                        stringToWrite = stringToWrite + enrollment.CompleteString + "\n";
                    }
                    string newPath = Path.GetFullPath(Path.Combine(filePath, @"..")) + $"\\{pair.Key}.csv";
                    File.WriteAllText(newPath, stringToWrite);
                }
            }
        }
    }
}
