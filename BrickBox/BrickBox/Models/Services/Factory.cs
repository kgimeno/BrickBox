using System;
using System.Configuration;         // Added for using the configuration file
using System.Collections.Specialized;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrickBox.Models.Services
{
    public class Factory
    {
        /**
         * Singleton design pattern used to make sure that only one object
         * is instantiated at any time by hiding the default constructor
         * and providing a getInstance() method
         */
        public Factory() { }
        private static Factory factory = new Factory();
        public static Factory GetInstance() { return factory; }

        /*
         * GetService method used to instantiate all services
         */
        public IService GetService(string serviceName)

        {
            Type type;
            Object obj = null;

            try
            {
                // Used to look up the impl name in web.config
                type = Type.GetType(GetImplName(serviceName));

                // Used to dynamicaly instantiate the implementation classes
                obj = Activator.CreateInstance(type);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

            return (IService)obj;
        }

        /*
         * GetImplName method used to look up the imple name in web.config
         */
        private string GetImplName(string serviceName)
        {
            NameValueCollection settings = ConfigurationManager.AppSettings;
            return settings.Get(serviceName);
        }
    }
}