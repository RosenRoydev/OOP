using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationAttributes.Attributes
{
   public class MyRangeAttribute : MyValidationAttribute
    {
        private int minValue;
        private int maxValue;

        public override object TypeId => base.TypeId;

        public MyRangeAttribute(int minValue, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }

       

        public override bool IsValid(object obj)
        => (int)obj >= minValue && (int)obj < maxValue;
    }
}
