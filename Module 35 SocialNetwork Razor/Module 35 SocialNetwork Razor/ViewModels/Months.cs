using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Module_35_SocialNetwork_Razor.ViewModels
{
    public enum Months
    {
        [Display(Name = "Январь")]
        Jan = 1,
        [Display(Name = "Февраль")]
        Feb,
        [Display(Name = "Март")]
        Mar,
        [Display(Name = "Апрель")]
        Apr,
        [Display(Name = "Май")]
        May,
        [Display(Name = "Июнь")]
        Jun,
        [Display(Name = "Июль")]
        Jul,
        [Display(Name = "Август")]
        Aug,
        [Display(Name = "Сентябрь")]
        Sep,
        [Display(Name = "Октябрь")]
        Oct,
        [Display(Name = "Ноябрь")]
        Nov,
        [Display(Name = "Декабрь")]
        Dec
    }
}
