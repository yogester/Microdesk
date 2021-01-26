using Microdesk.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microdesk.BusinessLogic
{
   public class MockStudentRepository : IStudentRepository
    {

        private List<Student> _studentList;
        public MockStudentRepository()
        {
            _studentList = new List<Student>()
                                {
                                new Student() { Id = 1, Name = "The value read from the database is: Yogendra" },
                                new Student() { Id = 2, Name = "The value read from the database is: Kevin" },

                                };
        }
        public Student GetStudent(int Id)
        {
            return this._studentList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
