namespace SchoolManagementAPI.Model
{
    public class StudentDetailsForDropDown
    {
        public StudentDetailsForDropDown() { }

        int _studentIdForDrpDwn;
        public int StudentIdForDrpDwn
        {
            get { return _studentIdForDrpDwn; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Student Id can not be less than 0.");
                _studentIdForDrpDwn = value;
            }
        }

        string _studentFullNameForDrpDwn = string.Empty;
        public string StudentFullNameForDrpDwn
        {
            get { return _studentFullNameForDrpDwn; }
            set
            {
                _studentFullNameForDrpDwn = value;
            }
        }
    }
}
