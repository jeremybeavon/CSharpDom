using System;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class GenericParameterReferenceWithCodeAnalysis :
        EditableGenericParameterReference,
        ITypeReferenceWithCodeAnalysis,
        IHasSyntax<IdentifierNameSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly Node<GenericParameterReferenceWithCodeAnalysis, IdentifierNameSyntax> node;

        internal GenericParameterReferenceWithCodeAnalysis()
        {
            node = new Node<GenericParameterReferenceWithCodeAnalysis, IdentifierNameSyntax>(this);
        }

        public override string Name
        {
            get { return Syntax.Identifier.Text; }
            set { Syntax = Syntax.WithIdentifier(SyntaxFactory.Identifier(value)); }
        }

        public IdentifierNameSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        TypeSyntax IHasSyntax<TypeSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (IdentifierNameSyntax)value; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitGenericParameterReferenceWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
