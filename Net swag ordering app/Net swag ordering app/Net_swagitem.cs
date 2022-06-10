using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net_swag_ordering_app
{
    public class Net_swagItem
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int OrderDate { get; set; }

        public string Shirtsize { get; set; }
        public string Shirtcolor { get; set; }
        public int Shipping { get; set; }

    }
    
}
