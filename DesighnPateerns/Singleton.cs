using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesighnPateerns
{
    public class Singleton
    {
        private Student _instance;
        private object _lock;
        public Student Instance
        {
            get
            {
                if (_instance == null)
                    lock (_lock)
                    {
                        if (_instance == null)
                            return new Student();
                    }
                return _instance;
            }
        }
    }

    public class BetterSingleton
    {
        private static object _instance;

        static BetterSingleton()
        {
            _instance = new object();
        }

        public object Instance => _instance;
    }

}
