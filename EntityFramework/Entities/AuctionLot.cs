using EntityFramework.Interfaces;
using System;

namespace EntityFramework.Entities
{
    public class AuctionLot : IEntity
    {
        public int ID { get; set; }

        public DateTime Date { get; set; }

        public int? AuctionLotItemID { get; set; }

        public virtual AuctionLotItem AuctionLotItem {get;set;}

        public int? OrphanID { get; set; }

        public virtual Orphan Orphan { get; set; }

        //[BindNever] // TO DO: Decide what do with this, i think add ASP.Core library in this project is bad choise
        public bool IsDeleted { get; set; } = false;
    }
}