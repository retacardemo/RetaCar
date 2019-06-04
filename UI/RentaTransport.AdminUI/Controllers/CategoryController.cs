using RentaTransport.AdminUI.Controllers.BaseControllers;
using RentaTransport.AdminUI.Models;
using RentaTransport.AdminUI.ServiceFacade;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators;

namespace RentaTransport.AdminUI.Controllers
{
    /// <summary>
    /// To do CategoryServiceFacade
    /// </summary>
    public class CategoryController : CrudController<CategoryViewModel,ColorServiceFacade, CategoryDTO, ICategoryRepository, CategoryValidator, CategoryService>
    {
        public CategoryController(ColorServiceFacade carAdditionServiceFacade) : base(carAdditionServiceFacade)
        {
        }
    }
}