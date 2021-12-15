using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationContext context)
        {
            //context.Database.EnsureDeleted();
            if (!context.Database.EnsureCreated())
            {
                return;
            }

            var sexs = new List<Sex>
            {
                new Sex {Value = "male"},
                new Sex {Value = "female"}
            };

            context.Sexes.AddRange(sexs);

            var deformations = new List<Deformation>
            {
                new Deformation {Value = "flat-feet"},
                new Deformation {Value = "valgus"},
                new Deformation {Value = "no-deformation"}
            };

            context.Deformations.AddRange(deformations);

            var temperaments = new List<Temperament>
            {
                new Temperament {Value = "flegma"},
                new Temperament {Value = "holeric"},
                new Temperament {Value = "sangvinic"},
                new Temperament {Value = "melanholic"}
            };

            context.Temperaments.AddRange(temperaments);

            var customtype = new List<CustomType>
            {
                new CustomType{Value = "based"},
                new CustomType{Value = "advanced"}

            };

            context.CustomTypes.AddRange(customtype);

            context.SaveChanges();

        }
    }
}
