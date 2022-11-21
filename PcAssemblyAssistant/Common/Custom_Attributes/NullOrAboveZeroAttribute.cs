using System.ComponentModel.DataAnnotations;

namespace Common.Custom_Attributes
{
    public class NullOrAboveZeroAttribute : ValidationAttribute
    {
        private int min = 0;
        private int max = int.MaxValue;

        public override bool IsValid(object? value)
        {
            return value == null ? true : ((int)value >= min && (int)value <= max) ? true : false;
        }

        public override string FormatErrorMessage(string name)
        {
            return base.FormatErrorMessage(name);
            // return string.Format(name, min, max);
        }
    }
}
