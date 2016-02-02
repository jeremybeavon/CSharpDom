using System;
using System.Reflection;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class NamedAttributeValueWithReflection : AbstractNamedAttributeValue//, IVisitable<IReflectionVisitor>
    {
        private readonly CustomAttributeNamedArgument attributeValue;

        internal NamedAttributeValueWithReflection(CustomAttributeNamedArgument attributeValue)
        {
            this.attributeValue = attributeValue;
        }

        public override string Name
        {
            get { return attributeValue.MemberName; }
        }

        public override string RawValue
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        
        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNamedAttributeValueWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
