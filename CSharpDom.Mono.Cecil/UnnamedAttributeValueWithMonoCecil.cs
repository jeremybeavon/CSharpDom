using System;
using System.Reflection;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.ConstantExpressions;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class UnnamedAttributeValueWithMonoCecil : AbstractUnnamedAttributeValue<IConstantExpressionWithMonoCecil>//, IVisitable<IReflectionVisitor>
    {
        private readonly CustomAttributeTypedArgument attributeValue;
        private readonly IConstantExpressionWithMonoCecil value;

        internal UnnamedAttributeValueWithMonoCecil(CustomAttributeTypedArgument attributeValue)
        {
            this.attributeValue = attributeValue;
            value = ConstantExpressionFactory.CreateExpression(attributeValue.Value);
        }

        public override IConstantExpressionWithMonoCecil Value
        {
            get { return value; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitUnnamedAttributeValueWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
