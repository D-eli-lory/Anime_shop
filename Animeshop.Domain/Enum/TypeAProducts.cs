using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Animeshop.Domain.Enum
{
    public enum TypeAProducts
    {
        [Display(Name = "Фигурки")]
        Figur = 0,

        [Display(Name = "Аксессуары")]
        Access = 1,

        [Display(Name = "Одежда")]
        Clothes = 2,

        [Display(Name = "Брелки")]
        Keychains = 3,

        [Display(Name = "Линзы")]
        Lenses = 4,

        [Display(Name = "Аниме-BOX")]
        Animebox = 5,
    }
}
