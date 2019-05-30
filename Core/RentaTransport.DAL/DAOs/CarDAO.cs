using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static RentaTransport.Common.Constants.Enums;

namespace RentaTransport.DAL.DAOs
{
    [Table("Cars")]
    public class CarDAO: BaseDAO
    {
        public Guid BrandId { get; set; }
        public Guid ModelId { get; set; }
        public Guid CityId { get; set; }
        public Guid BanTypeId { get; set; }
        public Guid ColorId { get; set; }
        public Guid FuelTypeId { get; set; }
        public Guid CarAdditionId { get; set; }
        public decimal DrivingDistance { get; set; }
        public decimal CarEngine { get; set; }
        public CarGear CarGear { get; set; }
        public Transmission Transmission { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public ICollection<CarImageDAO> CarImages { get; set; }

        [ForeignKey(nameof(BrandId))]
        public BrandDAO Brand { get; set; }

        [ForeignKey(nameof(ModelId))]
        public ModelDAO Model { get; set; }

        [ForeignKey(nameof(CityId))]
        public CityDAO City { get; set; }

        [ForeignKey(nameof(BanTypeId))]
        public BanTypeDAO BanType { get; set; }

        [ForeignKey(nameof(ColorId))]
        public ColorDAO Color { get; set; }

        [ForeignKey(nameof(FuelTypeId))]
        public FuelTypeDAO FuelType { get; set; }

        [ForeignKey(nameof(CarAdditionId))]
        public CarAdditionDAO CarAddition { get; set; }
    }
}
