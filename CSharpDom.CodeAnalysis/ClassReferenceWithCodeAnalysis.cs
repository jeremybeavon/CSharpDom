using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassReferenceWithCodeAnalysis :
        EditableClassReference<GenericParameterWithCodeAnalysis>,
        IHasSyntax<NameSyntax>,
        IHasNode<NameSyntax>
        //IVisitable<IReflectionVisitor>
    {
        private readonly UnspecifiedTypeReferenceWithCodeAnalysis typeReference;
        
        internal ClassReferenceWithCodeAnalysis(AttributeWithCodeAnalysis parent)
            : this(new UnspecifiedTypeReferenceWithCodeAnalysis(parent))
        {
        }

        internal ClassReferenceWithCodeAnalysis(UnspecifiedTypeReferenceWithCodeAnalysis typeReference)
        {
            this.typeReference = typeReference;
        }
    
        public override string Name
        {
            get { return typeReference.Name; }
            set { typeReference.Name = value; }
        }

        public override IList<GenericParameterWithCodeAnalysis> GenericParameters
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
