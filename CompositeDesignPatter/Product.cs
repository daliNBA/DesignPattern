using System;
using System.Collections.Generic;

namespace CompositeDesignPatter
{
    public class Product : Delivery
    {

        public override string Operation()
        {
            return "Product";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}
