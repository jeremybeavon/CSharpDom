using System;
using System.Reflection;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.ConstantExpressions;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class UnnamedAttributeValueWithReflection : AbstractUnnamedAttributeValue<IConstantExpressionWithReflection>//, IVisitable<IReflectionVisitor>
    {
        private readonly CustomAttributeTypedArgument attributeValue;
        private readonly IConstantExpressionWithReflection value;

        internal UnnamedAttributeValueWithReflection(CustomAttributeTypedArgument attributeValue)
        {
            this.attributeValue = attributeValue;
            value = ConstantExpressionFactory.CreateExpression(attributeValue.Value);
        }

        public override IConstantExpressionWithReflection Value
        {
            get { return value; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitUnnamedAttributeValueWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
