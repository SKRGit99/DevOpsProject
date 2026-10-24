namespace SchoolManagementAPI.Model
{
    public class Organization
    {
        string _schoolCode = string.Empty;
        protected string SchoolCode
        {
            get { return _schoolCode; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("School Code can not be null.");
                _schoolCode = value;
            }
        }

        string _schoolName = string.Empty;
        public string SchoolName
        {
            get { return _schoolName; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("School Name can not be null.");
                _schoolName = value;
            }
        }


        DateTime _establishmentYear = DateTime.MinValue;
        public DateTime EstablishmentYear
        {
            get { return _establishmentYear; }
            set { _establishmentYear = value; }
        }

        char _isSchoolRegistered;
        protected char IsSchoolRegistered
        {
            get { return _isSchoolRegistered; }
            set
            {
                if ((value != 'Y') && (value != 'N'))
                    throw new ArgumentException("Invalid Value. Please Enter Y/N.");
                _isSchoolRegistered = value;
            }
        }


        string _registrationNumber = string.Empty;
        protected string RegistrationNumber
        {
            get { return _registrationNumber; }
            set { _registrationNumber = value; }
        }

        char _isSchoolAffiliated;
        protected char IsSchoolAffiliated
        {
            get { return _isSchoolAffiliated; }
            set
            {
                if ((value != 'Y') && (value != 'N'))
                    throw new ArgumentException("Invalid Value. Please Enter Y/N.");
                _isSchoolAffiliated = value;
            }
        }

        string _affiliationBoard = string.Empty;
        public String AffiliationBoard
        {
            get { return _affiliationBoard; }
            set { _affiliationBoard = value; }
        }

        string? _motto;
        public string Motto
        {
            get { return _motto ?? string.Empty; }
            set { _motto = value; }
        }

        string? _vision;
        public string Vision
        {
            get { return _vision ?? string.Empty; }
            set { _vision = value; }
        }

        string? _description;
        public string Description
        {
            get { return _description ?? string.Empty; }
            set { _description = value; }
        }

        string _addressLine1 = string.Empty;
        public string AddressLine1
        {
            get { return _addressLine1; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("AddressLine1 can not be null.");
                _addressLine1 = value;
            }
        }

        string? _addressLine2;
        protected string AddressLine2
        {
            get { return _addressLine2 ?? string.Empty; }
            set { _addressLine2 = value; }
        }

        string _fullAddress = string.Empty;
        public string FullAddress
        {
            get { return _fullAddress; }
            set { _fullAddress = value; }
        }

        string _city = string.Empty;
        public String City
        {
            get { return _city; }
            set { _city = value; }
        }

        string _schoolState = string.Empty;
        public string SchoolState
        {
            get { return _schoolState; }
            set { _schoolState = value; }
        }

        string _country = string.Empty;
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        string _zipCode = string.Empty;
        public String ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }

        string _emailId = string.Empty;
        public string EmailId
        {
            get { return _emailId; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Email can not be null.");
                _emailId = value;

            }
        }

        string _websiteURL = string.Empty;
        public string WebsiteURL
        {
            get { return _websiteURL; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("WebsiteURL can not be null.");
                _websiteURL = value;
            }
        }

        string _schoolPhoneNumber = string.Empty;
        public string SchoolPhoneNumber
        {
            get { return _schoolPhoneNumber; }
            set { _schoolPhoneNumber = value; }
        }


        /*--------------------------------- Organization details -----------------------------------------------------*/


        int _employeeRelationShipId;
        public int EmployeeRelationShipId
        {
            get { return (int)_employeeRelationShipId; }
            set { _employeeRelationShipId = value; }
        }

        int _studentRelationShipId;
        public int StudentRelationShipId
        {
            get { return (int)_studentRelationShipId; }
            set { _studentRelationShipId = value; }
        }

        int _schoolRelationShipCategoryId;
        internal int SchoolRelationShipCategoryId
        {
            get { return _schoolRelationShipCategoryId; }
            set
            {
                if (value < 0)

                    throw new ArgumentException("School Id can not be less than 0.");
                _schoolRelationShipCategoryId = value;
            }
        }

        string _schoolRelationShipCategoryName = string.Empty;
        internal string SchoolRelationShipCategoryName
        {
            get { return _schoolRelationShipCategoryName; }

            set { _schoolRelationShipCategoryName = value; }


        }

        int _schoolDepartmentId;        //Department of the Related Individual
        public int SchoolDepartmentId
        {
            get { return (int)_schoolDepartmentId; }
            set
            {
                if (value < 0) throw new ArgumentException("DepartmentId can not be less than 0");
                _schoolDepartmentId = value;

            }
        }

        /*--------------------------------- Organization - Individual relationship details ----------------------------------*/

        public Organization()
        {
            this.SchoolCode = "SKRPAT01";
            this.SchoolName = "SKR International School";
            this.EstablishmentYear = DateTime.Parse("2018-03-18");
            this.IsSchoolRegistered = 'Y';
            this.RegistrationNumber = "SKRPATCBSE";
            this.IsSchoolAffiliated = 'Y';
            this.AffiliationBoard = "CBSE";
            this.Motto = "Education for everyone";
            this.Vision = "Education for Bihar";
            this.Description = "CBSE Affiliated School with AI Labs";
            this.AddressLine1 = "Saguna More";
            this.AddressLine2 = "Danapur";
            this.FullAddress = _addressLine1 + _addressLine2;
            this.City = "Patna";
            this.SchoolState = "Bihar";
            this.Country = "India";
            this.ZipCode = "800020";
            this.EmailId = "contact@skrschool.com";
            this.WebsiteURL = "www.skrschool.com";
            this.SchoolPhoneNumber = "81234144188";

        }
        public Organization(string schCode, string schName, string schRegNum, DateTime estYear, string affBoard, string motto,
                                   string vision, string schDesc, string addLine1, string addLine2, string city, string state, string country,
                                   string zipCode, string emailID, string schURL, string schPhoneNum)
        {
            this.SchoolCode = schCode;
            this.SchoolName = schName;
            this.RegistrationNumber = schRegNum;
            this.EstablishmentYear = estYear;
            this.AffiliationBoard = affBoard;
            this.Motto = motto;
            this.Vision = vision;
            this.Description = schDesc;
            this.AddressLine1 = addLine1;
            this.AddressLine2 = addLine2;
            this.City = city;
            this.SchoolState = state;
            this.Country = country;
            this.ZipCode = zipCode;
            this.EmailId = emailID;
            this.WebsiteURL = schURL;
            this.SchoolPhoneNumber = schPhoneNum;


        }



        public virtual Organization getOrganizationDetails()
        {
            Organization lstOrg = new Organization();

            return lstOrg;

        }

    }
}
