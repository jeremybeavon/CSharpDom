using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.ConstantExpressions;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class NamedAttributeValueWithMonoCecil : AbstractNamedAttributeValue<IConstantExpressionWithMonoCecil>//, IVisitable<IReflectionVisitor>
    {
        private readonly CustomAttributeNamedArgument attributeValue;
        private readonly IConstantExpressionWithMonoCecil value;

        internal NamedAttributeValueWithMonoCecil(AssemblyWithMonoCecil assembly, CustomAttributeNamedArgument attributeValue)
        {
            this.attributeValue = attributeValue;
            value = ConstantExpressionFactory.CreateExpression(assembly, attributeValue.Argument.Value);
        }

        public override string Name
        {
            get { return attributeValue.Name; }
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
