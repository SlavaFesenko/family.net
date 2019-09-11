using EntityFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Entities
{
    public class Person : IEntity, IAvatar
    {
        public int ID { get; set; }

        //TODO: AlPa -> customer Attr AllowSorting
        [Display(Name = "Повне ім'я")]
        public virtual FullName FullName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "День народження")]
        public virtual DateTime Birthday { get; set; }

        [Display(Name = "Рейтинг")]
        public float Rating { get; set; }

        [Display(Name = "Аватар")]
        public string Avatar { get; set; }

        public int EmailID { get; set; }


        //[BindNever] // TO DO: Decide what do with this, i think add ASP.Core library in this project is bad choise
        public bool IsDeleted { get; set; } = false;

        public virtual void CopyState(Person sender)
        {
            FullName.CopyState(sender.FullName);
            Birthday = sender.Birthday;
            Rating = sender.Rating;
            if(sender.Avatar != string.Empty && sender.Avatar != null)
            {
                Avatar = sender.Avatar;
            }
        }
    }

}
