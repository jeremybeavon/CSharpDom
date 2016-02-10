using System;
using System.Reflection;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.ConstantExpressions;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class NamedAttributeValueWithReflection : AbstractNamedAttributeValue<IConstantExpressionWithReflection>//, IVisitable<IReflectionVisitor>
    {
        private readonly CustomAttributeNamedArgument attributeValue;
        private readonly IConstantExpressionWithReflection value;

        internal NamedAttributeValueWithReflection(CustomAttributeNamedArgument attributeValue)
        {
            this.attributeValue = attributeValue;
            value = ConstantExpressionFactory.CreateExpression(attributeValue.TypedValue.Value);
        }

        public override string Name
        {
            get { return attributeValue.MemberName; }
        }

        public override IConstantExpressionWithReflection Value
        {
            get { return value; }
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
