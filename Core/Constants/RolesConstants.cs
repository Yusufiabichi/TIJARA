namespace Core.Constants
{
    public class RolesConstant
    {
        // Trade participants
        public const string Buyer = "Buyer";
        public const string Seller = "Seller";

        // Trade operations
        public const string Inspector = "Inspector";
        public const string LogisticsProvider = "LogisticsProvider";

        // Platform management
        public const string SupportStaff = "SupportStaff";
        public const string Moderator = "Moderator";
        public const string SuperAdmin = "SuperAdmin";
        public const string Admin = "Admin";

        public const string ALLUSERS_POLICY = "ALLUSERS_POLICY";
        public const string STAFFS_POLICY = "STAFFS_POLICY";
        public const string STUDENT_POLICY = "STUDENT_POLICY";
        public const string ADMINS_POLICY = "ADMINS_POLICY";
        public const string DEPARTMENT_POLICY = "DEPARTMENT_POLICY";

        // Roles that can only ever be held by one active user across the whole institution at a time;
        // the admin must remove the role from its current holder before it can be assigned to someone else.
        //public static readonly HashSet<string> InstitutionSingleOccupancyRoles = new()
        //{
        //    Director,
        //    Registrar,
        //    Bursar,
        //    ChiefSecurity,
        //    DeanStudentAffairs
        //};

        // Roles scoped to one holder per department (e.g. each department has its own HOD and its own Exam Officer).
        //public static readonly HashSet<string> DepartmentSingleOccupancyRoles = new()
        //{
        //    HOD,
        //    ExamOfficer
        //};

        // Roles scoped to one holder per faculty/school (e.g. each faculty has its own Dean and its own Chief Exam Officer).
        //public static readonly HashSet<string> FacultySingleOccupancyRoles = new()
        //{
        //    Dean,
        //    ChiefExamOfficer
        //};

        public static readonly Dictionary<string, string> RoleDisplayNames = new()
        {
            [Buyer] = "Buyer",
            [Seller] = "Seller",
            [Inspector] = "Inspector",
            [LogisticsProvider] = "Logistics Provider",
            [SupportStaff] = "Support Staff",
            [Moderator] = "Moderator",
            [Admin] = "Administrator",
            [SuperAdmin] = "Super Administrator"
        };
    }
}
