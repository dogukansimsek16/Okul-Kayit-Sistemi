using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer
{
    class EntityOgretmen
    {
        private int ogrtid;

        private int OGRTID
        {
            get { return ogrtid; }
            set { ogrtid = value; }
        }

        private string ogrtad;

        private string OGRTAD
        {
            get { return ogrtad; }
            set { ogrtad = value; }
        }

        private int ogrtbrans;

        private int OGRTBRANS
        {
            get { return ogrtbrans; }
            set { ogrtbrans = value; }
        }
    }
}
