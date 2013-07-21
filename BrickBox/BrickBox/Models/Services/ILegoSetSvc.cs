using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrickBox.Models.Domain;

namespace BrickBox.Models.Services
{
    public interface ILegoSetSvc : IService
    {
        LegoSet getSet(LegoSet legoSet);

        void addSet(LegoSet legoSet);

        void removeSet(LegoSet legoSet);
    }
}
