using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.ConstantExpressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class NamedAttributeValueWithCodeAnalysis : AbstractNamedAttributeValue<IConstantExpressionWithCodeAnalysis>//, IVisitable<IReflectionVisitor>
    {
        private readonly CustomAttributeNamedArgument attributeValue;
        private readonly IConstantExpressionWithCodeAnalysis value;

        internal NamedAttributeValueWithCodeAnalysis(AssemblyWithCodeAnalysis assembly, CustomAttributeNamedArgument attributeValue)
        {
            this.attributeValue = attributeValue;
            value = ConstantExpressionFactory.CreateExpression(assembly, attributeValue.Argument.Value);
        }

        public override string Name
        {
            get { return attributeValue.Name; }
        }

        public override IConstantExpressionWithCodeAnalysis Value
        {
            get { return value; }
        }
        
        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNamedAttributeValueWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
