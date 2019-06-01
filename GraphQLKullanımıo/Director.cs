using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLKullanımıo
{
    class Director
    {
        public string id { get; set; }
        public string name { get; set; }
        public int birth { get; set; }

        public List<Movie> movies { get; set; }
    }
}
