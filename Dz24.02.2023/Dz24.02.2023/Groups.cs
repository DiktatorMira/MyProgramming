using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dz24._02._2023 {
    internal class StudentGroup{
        Student[] StudentList;
        public StudentGroup() => StudentList = null;
        public StudentGroup(Student[] arr) {
            StudentList = new Student[arr.Length];
            for (short i = 0; i < arr.Length; i++) StudentList[i] = arr[i];
        }
        public IEnumerator GetEnumerator() {
            for (short i = 0; i < StudentList.Length; i++) yield return StudentList[i];
        }
        public int CompareToFIO(Student obj) {
            if (obj is Student) obj.FIO.CompareTo(obj.FIO);
            throw new NotImplementedException();
        }
        public int CompareToFaculty(IFaculty obj) {
            if (obj is IFaculty) obj.FacName.CompareTo(obj.FacName);
            throw new NotImplementedException();
        }
        public int CompareToGroup(Student obj) {
            if (obj is Student) obj.Group.CompareTo(obj.Group);
            throw new NotImplementedException();
        }
        public int CompareToDepartment(ProfDepartment obj) {
            if (obj is ProfDepartment) obj.DepName.CompareTo(obj.DepName);
            throw new NotImplementedException();
        }
    }
    internal class StudentGroupNotParents {
        Student[] StudentList;
        public StudentGroupNotParents() => StudentList = null;
        public StudentGroupNotParents(Student[] arr) {
            StudentList = new Student[arr.Length];
            for (short i = 0; i < arr.Length; i++) StudentList[i] = arr[i];
        }
        public IEnumerator GetEnumerator() {
            for (short i = 0; i < StudentList.Length; i++) yield return StudentList[i];
        }
        public int CompareToFIO(Student obj) {
            if (obj is Student && obj.GetParents() == true) obj.FIO.CompareTo(obj.FIO);
            throw new NotImplementedException();
        }
        public int CompareToFaculty(IFaculty obj1, Student obj2) {
            if (obj1 is IFaculty && obj2.GetParents() == true ) obj1.FacName.CompareTo(obj1.FacName);
            throw new NotImplementedException();
        }
        public int CompareToGroup(Student obj) {
            if (obj is Student && obj.GetParents() == true) obj.Group.CompareTo(obj.Group);
            throw new NotImplementedException();
        }
        public int CompareToDepartment(ProfDepartment obj1, Student obj2) {
            if (obj1 is ProfDepartment && obj2.GetParents() == true) obj1.DepName.CompareTo(obj1.DepName);
            throw new NotImplementedException();
        }
    }
    internal class TeacherGroup {
        Teacher[] TeacherList;
        public TeacherGroup() => TeacherList = null;
        public TeacherGroup(Teacher[] arr){
            TeacherList = new Teacher[arr.Length];
            for(short i = 0; i < arr.Length; i++) TeacherList[i] = arr[i];
        }
        public IEnumerator GetEnumerator() {
            for (short i = 0; i < TeacherList.Length; i++) yield return TeacherList[i];
        }
        public int CompareToFIO(Teacher obj) {
            if (obj is Teacher) obj.FIO.CompareTo(obj.FIO);
            throw new NotImplementedException();
        }
        public int CompareToFaculty(IFaculty obj) {
            if (obj is IFaculty) obj.FacName.CompareTo(obj.FacName);
            throw new NotImplementedException();
        }
        public int CompareToDepartment(IDepartment obj) {
            if (obj is IFaculty) obj.DepName.CompareTo(obj.DepName);
            throw new NotImplementedException();
        }
    }
}
