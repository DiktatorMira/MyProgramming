using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz24._02._2023 {
    interface IDepartment {
        string DepName { get; set; }
    }
    internal class Department : IDepartment {
        public string DepName { get; set; }
        public Department() : this(null) { }
        public Department(string name) => DepName = name;
    }
    internal class ProfDepartment : IDepartment {
        public string DepName { get; set; }
        public ProfDepartment() : this(null) { }
        public ProfDepartment(string name) => DepName = name;
    }
    interface IFaculty{
        string FacName { get; set; }
    }
    internal class Programmer : IFaculty {
        public string FacName { get; set; }
        public Programmer() :this(null) { }
        public Programmer(string name) => FacName = name;
    }
    internal class Designer : IFaculty {
        public string FacName { get; set; }
        public Designer() : this(null) { }
        public Designer(string name) => FacName = name;
    }
    internal class SysAdmin : IFaculty {
        public string FacName { get; set; }
        public SysAdmin() : this(null) { }
        public SysAdmin(string name) => FacName = name;
    }
}
