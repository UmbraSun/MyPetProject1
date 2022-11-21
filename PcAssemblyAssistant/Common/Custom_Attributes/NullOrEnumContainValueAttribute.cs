using Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Common.Custom_Attributes
{
    public class NullOrEnumContainValueAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            return value == null ? true : Enum.IsDefined(typeof(UnitsOfMeasure), (int)value);
        }
    }
}
