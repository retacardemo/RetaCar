using System;
using System.Threading.Tasks;
using AutoMapper;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentaTransport.AdminUI.Models;
using RentaTransport.AdminUI.ServiceFacade;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories.CrudRepositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators;
using RentaTransport.Common.Resources;
using static RentaTransport.Common.Constants.Enums;

namespace RentaTransport.AdminUI.Controllers.BaseControllers
{
    public class CrudController<TViewModel, TServiceFacade, TDto, TRepository, TValidator, TService> : BaseController
       where TViewModel : BaseViewModel
       where TDto : BaseDTO
       where TRepository : ICrudRepository<TDto>
       where TValidator : BaseValidator<TDto>
       where TService : CrudService<TDto, TRepository, TValidator>
       where TServiceFacade : CrudServiceFacade<TDto, TRepository, TValidator, TService>
    {
        private TServiceFacade _serviceFacade;

        public CrudController(TServiceFacade serviceFacade)
        {
            _serviceFacade = serviceFacade;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public virtual async Task<IActionResult> Form(Guid id)
        {
            if (id == default(Guid))
                ViewData["FormName"] = UI.Create;
            else
                ViewData["FormName"] = UI.Edit;

            var dto = await _serviceFacade.GetByIdAsync(id);
            var model = Mapper.Map<TViewModel>(dto);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual async Task<IActionResult> Save(TViewModel viewModel)
        {
            var dto = Mapper.Map<TDto>(viewModel);
            var response = await _serviceFacade.SaveAsync(dto);
            return Json(response);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual async Task<IActionResult> Remove(Guid id)
        {
            var response = await _serviceFacade.RemoveAsync(id);
            return Json(response);
        }

        [HttpGet]
        public async Task<IActionResult> Data(DataSourceLoadOptions loadOptions)
        {
            var data = await _serviceFacade.GetAllAsync(Status.Active);
            var loadResult = DataSourceLoader.Load(data, loadOptions);
            return Content(GetSerializeObject(loadResult), "application/json");
        }

        private static string GetSerializeObject(LoadResult loadResult)
        {
            var jsonSerializerSettings = new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            return JsonConvert.SerializeObject(loadResult, jsonSerializerSettings);
        }
    }
}