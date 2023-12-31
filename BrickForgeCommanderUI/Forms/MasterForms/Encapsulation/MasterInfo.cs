using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickForgeCommanderUI.MasterForms.Encapsulation
{
        public class MasterInfo
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public MasterInfo(int id, string name)
            {
                ID = id;
                Name = name;
            }
        }
}
