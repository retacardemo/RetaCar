using System;
using System.Collections.Generic;
using static RentaTransport.Common.Constants.Enums;

namespace RentaTransport.BLL.DTOs
{
    public class CarDTO: BaseDTO
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

        public BrandDTO Brand { get; set; }
        public ModelDTO Model { get; set; }
        public CityDTO City { get; set; }
        public BanTypeDTO BanType { get; set; }
        public ColorDTO Color { get; set; }
        public FuelTypeDTO FuelType { get; set; }
        public CarAdditionDTO CarAddition { get; set; }
        public ICollection<CarImageDTO> CarImages { get; set; }
    }
}
