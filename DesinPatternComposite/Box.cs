using System;
using System.Collections.Generic;
using System.Text;

namespace DesinPatternComposite
{
    public class Box : Delivery
    {
        protected List<Delivery> _deleveries = new List<Delivery>();
        public override void Add(Delivery delivery)
        {
            _deleveries.Add(delivery);
        }
        public override string Operation()
        {
            int i = 0;
            string result = "bransh";
            foreach (var item in _deleveries)
            {
                if(i != _deleveries.Count -1)
                {
                    result += "+";
                }
                i++;

            }
            result += ')';

            return result;
        }
    }
}
