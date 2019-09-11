using EntityFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Entities
{
    public class BaseItem : IEntity
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Назва")]
        public string Name { get; set; }

        [Display(Name = "Подробиці")]
        public string Description { get; set; }

        //[Required]
        //[Range(0.01, double.MaxValue,
            //ErrorMessage = "Please enter a positive price")]
        public float Price { get; set; }

        //[BindNever] // TO DO: Decide what do with this, i think add ASP.Core library in this project is bad choise
        public bool IsDeleted { get; set; } = false;

        [Display(Name = "Категорія")]
        public virtual ICollection<TypeBaseItem> TypeBaseItem { get; set; }
    }
}
