using Core.Dtos;
using Core.Repositories;
using Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Implementations
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
       public List<StudentDto> GetAll()
        {
            var dtos = _studentRepository.GetAll();
            return dtos.Select(dtos => new StudentDto { Id = dtos.Id, Name = dtos.Name }).ToList();
        }
    }
}
