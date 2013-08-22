/*****************************************************************************
 * BrickBox.Models.Services.IWishListSvc
 * IWishListSvc gets, adds, edits, and deletes a Lego set from the database
 * @author Kelly J Gimeno
 * @version 1
 * @date 08/22/2013
 *****************************************************************************/
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
        // Returns the Lego set that is retrieved from the database
        IQueryable<WishList> getSet(WishList set, Default db);

        // Adds Lego set to the database
        void addSet(WishList set, Default db);

        // Edits Lego set from the database
        void editSet(WishList set, Default db);

        // Deletes Lego set from the database
        void deleteSet(WishList set, Default db);
    }
}
