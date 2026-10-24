namespace SchoolManagementAPI.Model
{
    public class Student:Department
    {
        int id;
        public int Id
        {
            get { return id; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Student Id can not be less than 0.");
                id = value;
            }
        }

        string _studentFirstName = string.Empty;
        public string StudentFirstName
        {
            get { return _studentFirstName; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Student Fisrt Name can not be null.");
                _studentFirstName = value;
            }
        }


        string _studentMiddleName = string.Empty;
        public string StudentMiddleName
        {
            get { return _studentMiddleName; }
            set
            {
                _studentMiddleName = value;
            }
        }

        string _studentLastName = string.Empty;
        public string StudentLastName
        {
            get { return _studentLastName; }
            set
            {
                _studentLastName = value;
            }
        }

        string _studentName = string.Empty;
        public string StudentName
        {
            get { return _studentName; }
            set
            {
                _studentName = value;
            }
        }

        char _isRegisteredStudent;
        internal char IsRegisteredStudent
        {
            get { return _isRegisteredStudent; }

            set
            {
                if ((value != 'Y') && (value != 'N'))
                    throw new ArgumentException("Invalid Value. Please Select Y/N.");
                _isRegisteredStudent = value;
            }
        }

        string _studentRegistrationId = string.Empty;
        public string StudentRegistrationId
        {
            get { return _studentRegistrationId; }
            set { _studentRegistrationId = value; }
        }

        DateTime _studentRegistrationDate;
        public DateTime StudentRegistrationDate
        {
            get { return (DateTime)_studentRegistrationDate; }
            set { _studentRegistrationDate = value; }
        }


        int _rollNumber;
        public int RollNumber
        {
            get { return _rollNumber; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Roll number can not be lessa than 0.");
                _rollNumber = value;
            }
        }


        int _studentClass;
        public int StudentClass
        {
            get { return _studentClass; }
            set
            {
                _studentClass = value;
            }
        }

        int _studentSectionId;
        public int StudentSectionId
        {
            get { return _studentSectionId; }
            set { _studentSectionId = value; }
        }

        char _studentSectionName;
        public char StudentSectionName
        {
            get { return _studentSectionName; }
            set { _studentSectionName = value; }
        }


        string _studentPhoneNumber = string.Empty;
        public string StudentPhoneNumber
        {
            get { return _studentPhoneNumber; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Student Phone number can not be less than 0");
                _studentPhoneNumber = value;

            }
        }


        string _studentAddressLine1 = string.Empty;
        public string StudentAddressLine1
        {
            get { return _studentAddressLine1; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("AddressLine1 can not be null.");
                _studentAddressLine1 = value;
            }
        }

        string _studentAddressLine2 = string.Empty;
        public string StudentAddressLine2
        {
            get { return _studentAddressLine2; }
            set { _studentAddressLine2 = value; }
        }

        string _studentAddress = string.Empty;
        public string StudentAddress
        {
            get { return _studentAddress; }
            set
            {
                _studentAddress = value;
            }
        }

        string _studentCity = string.Empty;
        public string StudentCity
        {
            get { return _studentCity; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("City can not be null.");
                _studentCity = value;
            }
        }

        string _studentState = string.Empty;
        public string StudentState
        {
            get { return _studentState; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("State can not be null.");
                _studentState = value;
            }
        }

        string _studentCountry = string.Empty;
        public string StudentCountry
        {
            get { return _studentCountry; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Country can not be null.");
                _studentCountry = value;
            }
        }

        string _studentZipCode = string.Empty;
        public string StudentZipCode
        {
            get { return _studentZipCode; }
            set { _studentZipCode = value; }
        }

        string _studentEmailId = string.Empty;
        public string StudentEmailId
        {
            get { return _studentEmailId; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Student EmailID can not be null");
                _studentEmailId = value;
            }
        }


        public Student()
        {
            this.Id = 1;
            this.StudentFirstName = "Sampat";
            this.StudentMiddleName = "Kumar";
            this.StudentLastName = "Rahul";
            this.StudentName = StudentFirstName + StudentMiddleName + StudentLastName;
            this.IsRegisteredStudent = 'Y';
            this.StudentRegistrationId = "1";
            this.StudentRegistrationDate = DateTime.Parse("01/01/0001 00:00:00");
            this.RollNumber = 1;
            this.StudentClass = 1;
            this.StudentSectionId = 1;
            this.StudentSectionName = 'A';
            this.StudentPhoneNumber = "8123414418";
            this.StudentAddressLine1 = "Saguna More";
            this.StudentAddressLine2 = "Danapur Patna";
            this.StudentAddress = StudentAddressLine1 + StudentAddressLine2;
            this.StudentCity = "Patna";
            this.StudentState = "Bihar";
            this.StudentCountry = "India";
            this.StudentZipCode = "800020";
            this.StudentEmailId = "sampat@skr91.com";


        }

        public Student(int stdId, string stdFName, string stdMName, string stdLName, char isRegStudent, string stdRegId, DateTime stdDateReg,
                              int stdRollNum, int stdClass, int stdSecId, char stdSecName, string stdPhoneNum, string stdAddline1, string stdAddLine2,
                              string stdCity, string stdState, string stdZipCode, string stdEmailId, int deptId, string deptCode, string deptName,
                              string schCode, string schName, string schRegNum, DateTime estYear, string affBoard, string motto, string vision, string schDesc,
                              string addLine1, string addLine2, string city, string state, string country, string zipCode, string emailID, string schURL,
                              string schPhoneNum) : base(deptId, deptCode, deptName, schCode, schName, schRegNum, estYear, affBoard, motto, vision, schDesc, addLine1, addLine2, city, state, country, zipCode, emailID, schURL, schPhoneNum)
        {
            this.Id = stdId;
            this.StudentFirstName = stdFName;
            this.StudentMiddleName = stdMName;
            this.StudentLastName = stdLName;
            this.StudentName = stdFName + stdMName + stdLName;
            this.IsRegisteredStudent = isRegStudent;
            this.StudentRegistrationId = stdRegId;
            this.StudentRegistrationDate = stdDateReg;
            this.RollNumber = stdRollNum;
            this.StudentClass = stdClass;
            this.StudentSectionId = stdSecId;
            this.StudentSectionName = stdSecName;
            this.StudentPhoneNumber = stdPhoneNum;
            this.StudentAddressLine1 = stdAddline1;
            this.StudentAddressLine2 = stdAddLine2;
            this.StudentAddress = stdAddLine2 + stdAddLine2;
            this.StudentCity = stdCity;
            this.StudentState = stdState;
            this.StudentZipCode = stdZipCode;
            this.StudentEmailId = stdEmailId;

        }



    }



    public record CreateStudentDto(string Name);
    public record UpdateStudentDto(string Name);


}
