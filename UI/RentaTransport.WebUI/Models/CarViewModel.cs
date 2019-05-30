using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentaTransport.WebUI.Models.BaseViewModels;
using static RentaTransport.Common.Constants.Enums;

namespace RentaTransport.WebUI.Models
{
    public class CarViewModel: BaseViewModel
    {
        public Guid BrandId { get; set; }
        public Guid ModelId { get; set; }
        public Guid CityId { get; set; }
        public Guid BanTypeId { get; set; }
        public Guid ColorId { get; set; }
        public Guid FuelTypeId { get; set; }
        public Guid CarAdditionId { get; set; }
        public Guid CarImageId { get; set; }
        public decimal DrivingDistance { get; set; }
        public decimal CarEngine { get; set; }
        public CarGear CarGear { get; set; }
        public Transmission Transmission { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public BrandViewModel Brand { get; set; }
        public ModelViewModel Model { get; set; }
        public CityViewModel City { get; set; }
        public BanTypeViewModel BanType { get; set; }
        public ColorViewModel Color { get; set; }
        public FuelTypeViewModel FuelType { get; set; }
        public CarAdditionViewModel CarAddition { get; set; }
        public ICollection<CarImageViewModel> CarImages { get; set; }
    }
}
