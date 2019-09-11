using EntityFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Entities
{
    public class Location : IEntity
    {
        public float? MapCoordX { get; set; }

        public float? MapCoordY { get; set; }
        public int ID { get; set; }

        public virtual void CopyState(Location sender)
        {
            MapCoordX = sender.MapCoordX;
            MapCoordY = sender.MapCoordY;
        }

        //[BindNever] // TO DO: Decide what do with this, i think add ASP.Core library in this project is bad choise
        public bool IsDeleted { get; set; } = false;
    }
}
