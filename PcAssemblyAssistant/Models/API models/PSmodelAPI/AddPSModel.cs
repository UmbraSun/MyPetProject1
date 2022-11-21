using Common.Custom_Attributes;
using Common.Enums;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Models.API_models.PSmodelAPI
{
    public class AddPSModel : IServiceResult
    {
        /// <summary>
        /// Power Supply model
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Description
        /// </summary>
        public string? Description { get; set; }
        
        /// <summary>
        /// INT Power supply capacity (nominal)
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of MaxRAMFrequency cannot be.")]
        public int Capacity { get; set; }
        
        /// <summary>
        /// Unit Power supply capacity (nominal)
        /// </summary>
        [EnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure UnitOfCapacity { get; set; }

        /// <summary>
        /// producer country Id
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// PS cables
        /// </summary>
        public AddPSCablesModel? AddPSCablesModel { get; set; }

        /// <summary>
        /// PS certification
        /// </summary>
        public AddPSCertificationModel? AddPSCertificationModel { get; set; }

        /// <summary>
        /// PS cooling system
        /// </summary>
        public AddPSCoolingSystemModel? AddPSCoolingSystemModel { get; set; }

        /// <summary>
        /// PS electrical parametrs
        /// </summary>
        public AddPSElectricalParametrsModel? AddPSElectricalParametrsModel { get; set; }
    }
}
