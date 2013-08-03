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
        IQueryable<Inventory> getSet(Inventory set, Default db);
        void addSet(Inventory set, Default db);
        void editSet(Inventory set, Default db);
        void deleteSet(Inventory set, Default db);
    }
}
