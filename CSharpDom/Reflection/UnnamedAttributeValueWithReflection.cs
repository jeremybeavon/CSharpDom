using System;
using System.Reflection;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class UnnamedAttributeValueWithReflection : AbstractUnnamedAttributeValue, IVisitable<IReflectionVisitor>
    {
        private readonly CustomAttributeTypedArgument attributeValue;

        internal UnnamedAttributeValueWithReflection(CustomAttributeTypedArgument attributeValue)
        {
            this.attributeValue = attributeValue;
        }

        public override string RawValue
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitUnnamedAttributeValueWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }
    }
}
