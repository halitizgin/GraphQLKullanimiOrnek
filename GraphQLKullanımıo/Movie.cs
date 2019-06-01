using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLKullanımıo
{
    class Movie
    {
        public string id { get; set; }
        public string name { get; set; }
        public int year { get; set; }
        public int imdb { get; set; }
        public string subject { get; set; }

        public Director director { get; set; }
    }
}
