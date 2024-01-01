using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalExam.Models;

namespace FinalExam.Data
{
    public class FinalExamContext : DbContext
    {
        public FinalExamContext (DbContextOptions<FinalExamContext> options)
            : base(options)
        {
        }

        public DbSet<FinalExam.Models.Patient> Patient { get; set; } = default!;

        public DbSet<FinalExam.Models.Doctor>? Doctor { get; set; }

        public DbSet<FinalExam.Models.Appointment>? Appointment { get; set; }
    }
}
