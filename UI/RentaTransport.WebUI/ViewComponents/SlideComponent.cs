using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using RentaTransport.Common.Constants;
using RentaTransport.WebUI.Models;
using RentaTransport.WebUI.ServiceFacades;
using RentaTransport.WebUI.ViewModels;

namespace RentaTransport.WebUI.ViewComponents
{
    public class SlideComponent : ViewComponent
    {
        private readonly CarServiceFacade _carServiceFacade;

        public SlideComponent(CarServiceFacade carServiceFacade)
        {
            _carServiceFacade = carServiceFacade;
        }
        public IViewComponentResult Invoke()
        {
            var slides =  _carServiceFacade.GetAllAsync(Enums.Status.Active);
            var viewModel = new CommonViewModel
            {
                Slides = slides.Result.ToList()
            };
            return  View(viewModel);
        }
    }
}
