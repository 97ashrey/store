using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary.Models
{
    public class GroupModel
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public GroupModel()
        {

        }

        public GroupModel(string name)
        {
            Name = name;
        }

        public GroupModel(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public override string ToString()
        {
            return $"Group: {ID} \n" +
                   $"Name: {Name} \n";
        }
    }
}
