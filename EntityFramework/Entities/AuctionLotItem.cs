using System.Collections.Generic;

namespace EntityFramework.Entities
{
    public class AuctionLotItem : BaseItem
    {
        public virtual ICollection<AuctionLotItemType> AuctionLotItemTypes { get; set; }
    }
}