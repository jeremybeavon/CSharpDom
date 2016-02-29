using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.ConstantExpressions;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class UnnamedAttributeValueWithMonoCecil : AbstractUnnamedAttributeValue<IConstantExpressionWithMonoCecil>//, IVisitable<IReflectionVisitor>
    {
        private readonly CustomAttributeArgument attributeValue;
        private readonly IConstantExpressionWithMonoCecil value;

        internal UnnamedAttributeValueWithMonoCecil(AssemblyWithMonoCecil assembly, CustomAttributeArgument attributeValue)
        {
            this.attributeValue = attributeValue;
            value = ConstantExpressionFactory.CreateExpression(assembly, attributeValue.Value);
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
