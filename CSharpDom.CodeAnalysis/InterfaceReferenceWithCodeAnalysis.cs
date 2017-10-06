using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class InterfaceReferenceWithCodeAnalysis :
        EditableInterfaceReference<ITypeReferenceWithCodeAnalysis>,
        IHasSyntax<NameSyntax>,
        IHasNode<NameSyntax>,
        IInternalTypeReferenceWithCodeAnalysis//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly UnspecifiedTypeReferenceWithCodeAnalysis typeReference;
        
        internal InterfaceReferenceWithCodeAnalysis()
        {
            typeReference = new UnspecifiedTypeReferenceWithCodeAnalysis();
        }

        internal InterfaceReferenceWithCodeAnalysis(UnspecifiedTypeReferenceWithCodeAnalysis typeReference)
        {
            this.typeReference = typeReference;
        }

        public override IList<ITypeReferenceWithCodeAnalysis> GenericParameters
        {
            get { return typeReference.GenericParameters; }
            set { typeReference.GenericParameters = value; }
        }

        public override string Name
        {
            get { return typeReference.Name; }
            set { typeReference.Name = value; }
        }
        
        public NameSyntax Syntax
        {
            get { return typeReference.Syntax; }
            set { typeReference.Syntax = value; }
        }

        internal UnspecifiedTypeReferenceWithCodeAnalysis TypeReference
        {
            get { return typeReference; }
        }
        
        INode<NameSyntax> IHasNode<NameSyntax>.Node
        {
            get { return typeReference.Node; }
        }

        INode<TypeSyntax> IHasNode<TypeSyntax>.Node => throw new NotImplementedException();

        TypeSyntax IHasSyntax<TypeSyntax>.Syntax
        {
            get => typeReference.Syntax;
            set => typeReference.Syntax = (NameSyntax)value;
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitInterfaceReferenceWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
