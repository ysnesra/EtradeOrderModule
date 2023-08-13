using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtradeOrderModule.Domain.Entities
{
    public class BaseEntity 
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public BaseEntity()
        {
                
        }
        public BaseEntity(string id,DateTime createdDate) : this()
        {
            Id = id;
            CreatedDate = createdDate;
        }

    }
}
