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
        IQueryable<Inventory> getSet(Inventory set, BrickBoxContext db);
        void addSet(Inventory set, BrickBoxContext db);
        void editSet(Inventory set, BrickBoxContext db);
        void deleteSet(Inventory set, BrickBoxContext db);
    }
}
