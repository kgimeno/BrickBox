using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrickBox.Models.Domain;

namespace BrickBox.Models.Services
{
    public interface IWishListSvc : IService
    {
        IQueryable<WishList> getSet(WishList set, Default db);
        void addSet(WishList set, Default db);
        void editSet(WishList set, Default db);
        void deleteSet(WishList set, Default db);
    }
}
