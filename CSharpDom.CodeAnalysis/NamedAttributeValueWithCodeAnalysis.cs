using CSharpDom.BaseClasses;
using CSharpDom.Common.Expressions;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class NamedAttributeValueWithCodeAnalysis :
        EditableNamedAttributeValue<IExpression>,
        IHasSyntax<AttributeArgumentSyntax>//, IVisitable<IReflectionVisitor>
    {
        private readonly IConstantExpressionWithCodeAnalysis value;

        internal NamedAttributeValueWithCodeAnalysis(AssemblyWithCodeAnalysis assembly, CustomAttributeNamedArgument attributeValue)
        {
            this.attributeValue = attributeValue;
            value = ConstantExpressionFactory.CreateExpression(assembly, attributeValue.Argument.Value);
        }

        public override string Name
        {
            get { return Syntax.NameEquals.Name.Identifier.ValueText; }
            set { Syntax = Syntax.WithNameEquals(Syntax.NameEquals.WithName(Syntax.NameEquals.Name.WithIdentifier(new Microsoft.CodeAnalysis.SyntaxToken().va))) }
        }

        public override IConstantExpressionWithCodeAnalysis Value
        {
            get { return value; }
        }

        public AttributeArgumentSyntax Syntax { get; private set; }

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
