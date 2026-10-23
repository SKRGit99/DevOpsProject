using SchoolManagementAPI.Model;
namespace SchoolManagementAPI.Repo
{
    public class DepartmentRepo: OrganizationRepo
    {
        public DepartmentRepo(IConfiguration configuration) : base(configuration)
        {
            //_connString = configuration.GetConnectionString("SchoolManagementAppDbConnectionString");
        }

        public override Organization getOrganizationDetails()
        {
            Organization lstOrg = new Organization();

            return lstOrg;

        }

        public override void getOrganizationRelationshipDetails(int empId)
        {
            Organization orgEmpDet = new Organization();
            Console.WriteLine($"Relationship Id : {orgEmpDet.EmployeeRelationShipId} Relationship Category Id: {orgEmpDet.SchoolRelationShipCategoryId} Relationship Category Name : {orgEmpDet.SchoolRelationShipCategoryName} Relationship-Department Name :{orgEmpDet.SchoolDepartmentId} ");
        }

        public override void getOrganizationRelationshipDetails(int studentId, int? stuRollNum)
        {
            Organization orgStuDet = new Organization();
            Console.WriteLine($"Relationship Id : {orgStuDet.StudentRelationShipId} Relationship Category Id: {orgStuDet.SchoolRelationShipCategoryId} Relationship Category Name : {orgStuDet.SchoolRelationShipCategoryName} Relationship-Department Name :{orgStuDet.SchoolDepartmentId} ");
        }

        public virtual void getDepartmentDetails(int empId)
        {
            Department deptEmpDet = new Department();
            Console.WriteLine($"Department Id : {deptEmpDet.DepartmentId} Department Name :{deptEmpDet.DepartmentName}");
        }
        public virtual void getDepartmentDetails(int studentId, int? rollNum)
        {
            Department deptStuDet = new Department();
            Console.WriteLine($"Department Id : {deptStuDet.DepartmentId} Department Name :{deptStuDet.DepartmentName}");
        }

        public decimal getDepartmentWiseExpenses(int deptId)
        {
            decimal _deptExpenses = 0;

            return _deptExpenses;
        }
    }
}
