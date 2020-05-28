using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Portfolio.Core.Modelhelpers
{
    public class MaxValueAttribute : ValidationAttribute
    {
        private readonly int _maxValue;
        private readonly string _errorMessage;

        public MaxValueAttribute(int maxValue, string errorMessage)
        {
            _maxValue = maxValue;
            _errorMessage = errorMessage;
        }

        public override bool IsValid(object value)
        {
            return (int)value <= _maxValue;
        }

        public override string FormatErrorMessage(string name)
        {
            return _errorMessage;
        }
    }
}
