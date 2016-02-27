using System;
using System.Reflection;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.ConstantExpressions;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class NamedAttributeValueWithMonoCecil : AbstractNamedAttributeValue<IConstantExpressionWithMonoCecil>//, IVisitable<IReflectionVisitor>
    {
        private readonly CustomAttributeNamedArgument attributeValue;
        private readonly IConstantExpressionWithMonoCecil value;

        internal NamedAttributeValueWithMonoCecil(CustomAttributeNamedArgument attributeValue)
        {
            this.attributeValue = attributeValue;
            value = ConstantExpressionFactory.CreateExpression(attributeValue.TypedValue.Value);
        }

        public override string Name
        {
            get { return attributeValue.MemberName; }
        }

        public override IConstantExpressionWithMonoCecil Value
        {
            get { return value; }
        }
        
        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNamedAttributeValueWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
