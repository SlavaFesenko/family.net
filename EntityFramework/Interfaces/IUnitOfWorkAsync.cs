using EntityFramework.Entities;
using EntityFramework.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EntityFramework.Interfaces
{
    public interface IUnitOfWorkAsync : IIdentityAsync
    {
        IOrphanageAsyncRepository Orphanages { get; }
        IAsyncRepository<CharityMaker> CharityMakers { get; }
        IAsyncRepository<Representative> Representatives { get; }
        IAsyncRepository<Volunteer> Volunteers { get; }
        IAsyncRepository<Donation> Donations { get; }
        IAsyncRepository<Orphan> Orphans { get; }
        IAsyncRepository<BaseItemType> BaseItemTypes { get; }

        TypeBaseItemRepository TypeBaseItems { get; set; }// TODO : rewrite this

        void SaveChangesAsync();
    }
}