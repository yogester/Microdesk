using System;
using Microdesk.DataAccess;

namespace Microdesk.BusinessLogic
{
    public interface IStudentRepository
    {
        Student GetStudent(int id);
        
    }
}
