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
                new Sex {Value = "male", UserFriendlyInfo = "мужской"},
                new Sex {Value = "female", UserFriendlyInfo = "женский"}
            };

            context.Sexes.AddRange(sexs);

            var sizes = new List<Size>
            {
                new Size {Value = "36"},
                new Size {Value = "37"},
                new Size {Value = "38"},
                new Size {Value = "39"},
                new Size {Value = "40"},
                new Size {Value = "41"},
                new Size {Value = "42"}
            };

            context.Sizes.AddRange(sizes);

            var basemodels = new List<BaseModel>
            {
                new BaseModel {Type = "woman1"},
                new BaseModel {Type = "woman2"},
                new BaseModel {Type = "woman3"},
                new BaseModel {Type = "man1"},
                new BaseModel {Type = "man2"},
                new BaseModel {Type = "man3"}
            };

            context.BaseModels.AddRange(basemodels);

            var colorpallets = new List<ColorPallet>
            {
                new ColorPallet {Temperament = "flegma"},
                new ColorPallet {Temperament = "holeric"},
                new ColorPallet {Temperament = "sangvinic"},
                new ColorPallet {Temperament = "melanholic"}
            };

            context.ColorPallets.AddRange(colorpallets);

            var deformations = new List<Deformation>
            {
                new Deformation {Value = "flat-feet", UserFriendlyInfo = "плоскостопие"},
                new Deformation {Value = "valgus", UserFriendlyInfo = "вальгусная деформация"},
                new Deformation {Value = "no-deformation", UserFriendlyInfo = "нет деформации"}
            };

            context.Deformations.AddRange(deformations);

            var temperaments = new List<Temperament>
            {
                new Temperament {Value = "flegma", UserFriendlyInfo = "флегматик"},
                new Temperament {Value = "holeric", UserFriendlyInfo = "холерик"},
                new Temperament {Value = "sangvinic", UserFriendlyInfo = "сангвиник"},
                new Temperament {Value = "melanholic", UserFriendlyInfo = "меланхолик"}
            };

            context.Temperaments.AddRange(temperaments);

            var customtype = new List<CustomType>
            {
                new CustomType{Value = "based", UserFriendlyInfo = "базовый"},
                new CustomType{Value = "advanced", UserFriendlyInfo = "продвинутый"}
            };

            context.CustomTypes.AddRange(customtype);

            context.SaveChanges();

        }
    }
}
