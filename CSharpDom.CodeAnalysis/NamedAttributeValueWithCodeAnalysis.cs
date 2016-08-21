using CSharpDom.Common.Expressions;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    public sealed class NamedAttributeValueWithCodeAnalysis :
        EditableNamedAttributeValue<IExpression>,
        IHasSyntax<AttributeArgumentSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly Func<AttributeArgumentSyntax> getArgument;
        private readonly Action<AttributeArgumentSyntax> setArgument;


        internal NamedAttributeValueWithCodeAnalysis(AttributeWithCodeAnalysis parent)
        {
            internalId = Guid.NewGuid();
            Parent = parent;
            getArgument = () => Parent.NamedValueList.GetChild(this);
            setArgument = syntax => Parent.NamedValueList.SetChild(this, syntax);
        }

        public override string Name
        {
            get { return getArgument().NameEquals.Name.Identifier.Text; }
            set
            {
                AttributeArgumentSyntax argument = getArgument();
                setArgument(argument.WithNameEquals(argument.NameEquals.WithName(SyntaxFactory.IdentifierName(value))));
            }
        }
        
        //public override IConstantExpressionWithCodeAnalysis Value
        //{
        //    get { return value; }
        //}

        public AttributeArgumentSyntax Syntax
        {
            get { return getArgument(); }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }

        internal AttributeWithCodeAnalysis Parent { get; set; }

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
