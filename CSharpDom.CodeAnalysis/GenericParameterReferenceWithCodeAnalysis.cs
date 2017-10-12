using System;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class GenericParameterReferenceWithCodeAnalysis :
        EditableGenericParameterReference,
        IInternalTypeReferenceWithCodeAnalysis,
        IHasSyntax<IdentifierNameSyntax>//,
        //IHasNode<IdentifierNameSyntax>//,
        //IHasNode<NameSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly UnspecifiedTypeReferenceWithCodeAnalysis typeReference;

        public GenericParameterReferenceWithCodeAnalysis(string name)
            : this(new UnspecifiedTypeReferenceWithCodeAnalysis(name))
        {
        }

        internal GenericParameterReferenceWithCodeAnalysis(UnspecifiedTypeReferenceWithCodeAnalysis typeReference)
        {
            this.typeReference = typeReference;
        }

        public override string Name
        {
            get { return typeReference.Name; }
            set { typeReference.Name = value; }
        }

        public IdentifierNameSyntax Syntax
        {
            get { return (IdentifierNameSyntax)typeReference.Syntax; }
            set { typeReference.Syntax = value; }
        }

        internal UnspecifiedTypeReferenceWithCodeAnalysis TypeReference
        {
            get { return typeReference; }
        }

        TypeSyntax IHasSyntax<TypeSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (IdentifierNameSyntax)value; }
        }

        INode<TypeSyntax> IHasNode<TypeSyntax>.Node => typeReference.Node;

        //INode<NameSyntax> IHasNode<NameSyntax>.Node => throw new NotImplementedException();

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
