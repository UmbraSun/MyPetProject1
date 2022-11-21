using Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Common.Custom_Attributes
{
    public class EnumContainValueAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            return Enum.IsDefined(typeof(UnitsOfMeasure), (int)value);
        }
    }
}
