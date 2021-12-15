using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class TestResults
    {
        public int ID { get; set; }
        public Sex Sex { get; set; }
        public Deformation Deformation { get; set; }
        public Temperament Temperament { get; set; }
        public CustomType  CustomType{ get; set; }


    }
}
