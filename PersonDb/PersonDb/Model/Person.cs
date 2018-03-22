using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonDb.Model
{
    public partial class Person
    {
        public Person()
        {
            Phone = new HashSet<Phone>();
        }

        public long Id { get; set; }
        [Column(TypeName = "nchar(10)")]
        public string Name { get; set; }
        public short? Age { get; set; }

        [InverseProperty("Person")]
        public ICollection<Phone> Phone { get; set; }
    }
}
