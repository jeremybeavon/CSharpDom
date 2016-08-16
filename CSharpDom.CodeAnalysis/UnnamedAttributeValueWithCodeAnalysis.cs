using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.ConstantExpressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class UnnamedAttributeValueWithCodeAnalysis : AbstractUnnamedAttributeValue<IConstantExpressionWithCodeAnalysis>//, IVisitable<IReflectionVisitor>
    {
        private readonly CustomAttributeArgument attributeValue;
        private readonly IConstantExpressionWithCodeAnalysis value;

        internal UnnamedAttributeValueWithCodeAnalysis(AssemblyWithCodeAnalysis assembly, CustomAttributeArgument attributeValue)
        {
            this.attributeValue = attributeValue;
            value = ConstantExpressionFactory.CreateExpression(assembly, attributeValue.Value);
        }

        public override IConstantExpressionWithCodeAnalysis Value
        {
            get { return value; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitUnnamedAttributeValueWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
