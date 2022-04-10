using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvailityCSharpAssessment
{
    internal class Enrollment
    {
        private string completeString;
        private string userID;
        private string firstName;
        private string lastName;
        private int version;
        private string insuranceCompany;
        private string completeName;
        private int columnCount;

        /// <summary>
        /// Class for storing the data read from each line of an enrollment file.
        /// </summary>
        /// <param name="enrollmentString">Line from an enrollment file in string format.</param>
        internal Enrollment(string enrollmentString)
        {
            this.CompleteString = enrollmentString;
            string[] splitLine = enrollmentString.Split(',');
            this.ColumnCount = splitLine.Length;
            if(ColumnCount == 5)
            {
                this.UserID = splitLine[0];
                this.FirstName = splitLine[1];
                this.LastName = splitLine[2];
                this.Version = Int32.Parse(splitLine[3]);
                this.InsuranceCompany = splitLine[4];
                this.CompleteName = splitLine[2] + splitLine[1];
            }
        }

        /// <summary>
        /// Gets or sets the complete string.
        /// </summary>
        public string CompleteString
        {
            get { return completeString; }
            private set { completeString = value; }
        }

        /// <summary>
        /// Gets or sets the user ID.
        /// </summary>
        public string UserID
        {
            get { return userID; }
            private set { userID = value; }
        }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            private set { firstName = value; }
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            private set { lastName = value; }
        }

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        public int Version
        {
            get { return version; }
            private set { version = value; }
        }

        /// <summary>
        /// Gets or sets the insurance company name.
        /// </summary>
        public string InsuranceCompany
        {
            get { return insuranceCompany; }
            private set { insuranceCompany = value; }
        }

        /// <summary>
        /// Gets or sets the complete name.
        /// </summary>
        public string CompleteName
        {
            get { return completeName; }
            private set { completeName = value; }
        }

        /// <summary>
        /// Gets or sets the column count.
        /// </summary>
        public int ColumnCount
        {
            get { return columnCount; }
            private set { columnCount = value; }
        }

    }
}
