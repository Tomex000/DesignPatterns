using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    class Singleton
    {
        private static Singleton instance;
        private static readonly Object padLock = new Object();
        public static Singleton Instance 
        {
            get
            {
                if (instance == null)
                {
                    lock (padLock)
                    {
                        if (instance ==null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }
        
        private Singleton()
        {

        }
    }
}
