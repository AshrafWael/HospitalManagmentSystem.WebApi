﻿using HospitalManagmentSystem.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSystem.BLL.Dtos
{
    public class PatientUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int DoctorId { get; set; }
        public ICollection<IssueReadDto> Issues { get; set; } = new HashSet<IssueReadDto>();
    }
}
