using MarketPlace.Domain.Entites.Site;
using MarketPlace.Domain.Services.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Domain.Services.EntitesExtensions
{
   public static class SliderExtensions
    {
        public static string GetSliderImageAddress(this Slider slider)
        {
            return PathExtension.SliderOrigin + slider.ImageName;
        }
    }
}
