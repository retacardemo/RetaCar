using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentaTransport.BLL.Repositories.CrudRepositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators;
using RentaTransport.Common.Constants;
using RentaTransport.Common.Resources;
using RentaTransport.WebUI.Models;
using RentaTransport.WebUI.ServiceFacades.CrudServiceFacades;

namespace RentaTransport.WebUI.Controllers.BaseControllers
{
    public abstract class IdentityCrudController<TViewModel, TServiceFacade, TDto, TRepository, TValidator, TService> : BaseController
       where TViewModel : BaseViewModel
       where TDto : class
       where TRepository : IIdentityCrudRepository<TDto>
       where TValidator : BaseIdentityValidator<TDto>
       where TService : IdentityCrudService<TDto, TRepository, TValidator>
       where TServiceFacade : IdentityCrudServiceFacade<TDto, TRepository, TValidator, TService>
    {
        private readonly TServiceFacade _serviceFacade;

        public IdentityCrudController(TServiceFacade serviceFacade)
        {
            _serviceFacade = serviceFacade;
        }

        [HttpGet]
        public IActionResult Index() => View();

        [HttpGet]
        public virtual async Task<IActionResult> Form(Guid id)
        {
            if (id == default(Guid))
                ViewData["FormName"] = UI.Create;
            else
                ViewData["FormName"] = UI.Edit;

            var dto = await _serviceFacade.GetByIdAsync(id, Enums.Status.Active);
            var model = Mapper.Map<TViewModel>(dto);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Data(DataSourceLoadOptions loadOptions)
        {
            var data = await _serviceFacade.GetAllAsync(Enums.Status.Active);
            var loadResult = DataSourceLoader.Load(data, loadOptions);
            return Content(GetSerializeObject(loadResult), "application/json");
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