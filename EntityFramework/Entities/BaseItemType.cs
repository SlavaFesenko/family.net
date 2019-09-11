using EntityFramework.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Entities
{
    public class BaseItemType : IEntity
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Назва")]
        public string Name { get; set; }

        [Display(Name = "Родитель")]
        public virtual BaseItemType Parent { get; set; }

        //[BindNever] // TO DO: Decide what do with this, i think add ASP.Core library in this project is bad choise
        public bool IsDeleted { get; set; } = false;

        [Display(Name = "Потреби")]
        public virtual ICollection<TypeBaseItem> TypeBaseItem { get; set; }
    }
}