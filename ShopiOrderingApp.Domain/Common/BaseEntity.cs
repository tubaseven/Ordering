using System;

namespace ShopiOrderingApp.Domain
{
    public class BaseEntity
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
