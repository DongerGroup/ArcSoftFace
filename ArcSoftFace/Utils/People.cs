using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcSoftFace.Utils
{
    public class People
    {
        public string name;
        public Dictionary<string, IntPtr> images;
        public People()
        {
            name = null;
            images = null;
        }
        public People(string _name, KeyValuePair<string, IntPtr> keyValuePair)
        {
            name = _name;
            images = null;
            images.Add(keyValuePair);
        }
        public void Add(KeyValuePair<string, IntPtr> keyValuePair)
        {
            images.Add(keyValuePair);
        }
    }
}
