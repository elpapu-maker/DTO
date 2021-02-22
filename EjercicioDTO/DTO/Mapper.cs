using AutoMapper;
using EjercicioDTO.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioDTO.DTO
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<StudentDTO, Student>();
            CreateMap<Student, StudentDTO>();

            
        }
    }
}

