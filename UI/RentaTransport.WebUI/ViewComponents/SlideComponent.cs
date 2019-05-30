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
        public ViewViewComponentResult Invoke()
        {
            var dto = _carServiceFacade.GetAllAsync(Enums.Status.Active);
            var models = Mapper.Map<IEnumerable<CarViewModel>>(dto);
            var viewModel = new CommonViewModel
            {
                Slides = models
            };
            return View(viewModel);
        }
    }
}
