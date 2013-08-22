/*****************************************************************************
 * BrickBox.Models.Services.IInventorySvc
 * IInventorySvc gets, adds, edits, and deletes a Lego set from the database
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
    public interface IInventorySvc : IService
    {
        // Returns the Lego set that is retrieved from the database
        IQueryable<Inventory> getSet(Inventory set, Default db);

        // Adds Lego set to the database
        void addSet(Inventory set, Default db);

        // Edits Lego set from the database
        void editSet(Inventory set, Default db);

        // Deletes Lego set from the database
        void deleteSet(Inventory set, Default db);
    }
}
