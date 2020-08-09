using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace api1.Models
{
    public partial class ContosouniversityContext : DbContext
    {
        public override int SaveChanges()
        {
            // TODO

            return base.SaveChanges();
        }
    }
}