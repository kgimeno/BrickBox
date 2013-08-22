/*****************************************************************************
 * BrickBox.Models.Business.Manager
 * Manager class used as a SuperType class to promote decoupling from the 
 *   factory while still "getting services"
 * @author Kelly J Gimeno
 * @version 1
 * @date 08/22/2013
 *****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BrickBox.Models.Domain;
using BrickBox.Models.Services;

namespace BrickBox.Models.Business
{
    public abstract class Manager   // abstract class to because it's never intended to be instantiated
    {
        private Factory factory = Factory.GetInstance();

        protected IService GetService(string name, params object[] args) // protected access because it is not to be used outside inheritance
        {
            return factory.GetService(name, args);
        }
    }
}