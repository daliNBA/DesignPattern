using System;

namespace CompositeDesignPatter
{
    public abstract class Delivery
    {
        public Delivery(){}
        public abstract string Operation();
        public virtual void Add(Delivery box)
        {
            throw new NotImplementedException();
        }
        public virtual void Remove(Delivery box)
        {
            throw new NotImplementedException();
        }
        public virtual bool IsComposite()
        {
            return true;
        }
    }
}
