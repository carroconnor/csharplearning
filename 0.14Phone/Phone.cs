using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14Phone
{
    class Phone
    {
        public Phone(string makemake, int modelmodel)
        {
            this.MakeMake = makemake;
            this.ModelModel = modelmodel;
        }

        public string MakeMake { get; set; }
        public int ModelModel { get; set; }
    }
}
