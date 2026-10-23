using SchoolManagementAPI.Model;
namespace SchoolManagementAPI.Repo
{
    public class OrganizationRepo
    {
        protected readonly string? _connString;

        public OrganizationRepo(IConfiguration configuration)
        {
            _connString = configuration.GetConnectionString("SchoolManagementAppDbConnectionString");
        }
        public virtual Organization getOrganizationDetails()
        {
            Organization lstOrg = new Organization();

            return lstOrg;

        }

        public virtual void getOrganizationRelationshipDetails(int empId)
        {
            Organization orgEmpDet = new Organization();

            Console.WriteLine($"Relationship Id : {orgEmpDet.EmployeeRelationShipId} Relationship Category Id: {orgEmpDet.SchoolRelationShipCategoryId} Relationship Category Name : {orgEmpDet.SchoolRelationShipCategoryName} Relationship-Department Name :{orgEmpDet.SchoolDepartmentId} ");
        }

        public virtual void getOrganizationRelationshipDetails(int studentId, int? stuRollNum)
        {
            Organization orgStuDet = new Organization();
            Console.WriteLine($"Relationship Id : {orgStuDet.StudentRelationShipId} Relationship Category Id: {orgStuDet.SchoolRelationShipCategoryId} Relationship Category Name : {orgStuDet.SchoolRelationShipCategoryName} Relationship-Department Name :{orgStuDet.SchoolDepartmentId} ");
        }

    }
}
