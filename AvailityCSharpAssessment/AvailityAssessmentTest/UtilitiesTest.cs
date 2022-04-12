using Microsoft.VisualStudio.TestTools.UnitTesting;
using AvailityCSharpAssessment;
using System.IO;
using System.Collections.Generic;

namespace AvailityAssessmentTest
{
    [TestClass]
    public class UtilitiesTest
    {
        [TestMethod]
        public void ReadCSVFile_Test()
        {
            string filePath = Directory.GetCurrentDirectory() + "\\TestEnrollment_NoDuplicates.csv";
            List<string> expected = new List<string>()
            {
                "12459,Liam,Elsher,1,United Health",
                "12460,Olivia,Solace,2,Kaiser Foundation",
                "12461,Noah,Levine,3,Anthem Inc",
                "12462,Emma,Thatcher,4,Centene Corporation",
                "12463,Oliver,Raven,5,Humana",
                "12464,Ava,Bardot,6,CVS",
                "12465,Elijah,St. James,7,Health Care Service Corporation (HCSC)",
                "12466,Charlotte,Hansley,8,CIGNA",
                "12467,William,Cromwell,9,Molina Healthcare",
                "12468,Sophia,Ashley,10,Independence Health Group",
                "12469,James,Monroe,11,Guidewell Mutual Holding",
                "12470,Amelia,West,12,California Physicians Service",
                "12471,Benjamin,Langley,13,Highmark Group",
                "12472,Isabella,Daughtler,14,Blue Cross Blue Shield of Michigan",
                "12473,Lucas,Madison,15,Blue Cross of California",
                "12474,Mia,Marley,16,Blue Cross Blue Shield of New Jersey",
                "12475,Henry,Ellis,17,Caresource",
                "12476,Evelyn,Hope,18,UPMC Health System",
                "12477,Alexander,Cassidy,19,Health Net of California",
            };

            List<string> actual = Utilities.ReadCSVFile(filePath);
            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
