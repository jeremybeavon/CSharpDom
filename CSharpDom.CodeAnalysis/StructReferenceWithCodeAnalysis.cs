﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructReferenceWithCodeAnalysis :
        EditableStructReference<ITypeReferenceWithCodeAnalysis>,
        IHasSyntax<NameSyntax>,
        IHasNode<NameSyntax>,
        IInternalTypeReferenceWithCodeAnalysis
        //IVisitable<IReflectionVisitor>
    {
        private readonly UnspecifiedTypeReferenceWithCodeAnalysis typeReference;
        
        internal StructReferenceWithCodeAnalysis(UnspecifiedTypeReferenceWithCodeAnalysis typeReference)
        {
            this.typeReference = typeReference;
        }
    
        public override string Name
        {
            get { return typeReference.Name; }
            set { typeReference.Name = value; }
        }

        public override IList<ITypeReferenceWithCodeAnalysis> GenericParameters
        {
            get { return typeReference.GenericParameters; }
            set { typeReference.GenericParameters = value; }
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

        INode<TypeSyntax> IHasNode<TypeSyntax>.Node => typeReference.Node;

        TypeSyntax IHasSyntax<TypeSyntax>.Syntax {
            get => typeReference.Syntax;
            set => ((IInternalTypeReferenceWithCodeAnalysis)typeReference).Syntax = value;
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitClassReferenceWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
