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
        ITypeReferenceWithCodeAnalysis,
        IHasSyntax<NameSyntax>
        //IVisitable<IReflectionVisitor>
    {
        private readonly Node<ClassReferenceWithCodeAnalysis, NameSyntax> node;
        private GenericParameterListWrapper<ClassReferenceWithCodeAnalysis> genericParameters;
        
        internal ClassReferenceWithCodeAnalysis(AttributeWithCodeAnalysis parent)
            : this()
        {
            AttributeParent = parent;
        }

        private ClassReferenceWithCodeAnalysis()
        {
            node = new Node<ClassReferenceWithCodeAnalysis, NameSyntax>(this);
            genericParameters = new GenericParameterListWrapper<ClassReferenceWithCodeAnalysis>(
                node,
                syntax => syntax.ToGenericParameters(),
                (parentSyntax, childSyntax) => parentSyntax.WithGenericParameters(childSyntax),
                parent => new GenericParameterWithCodeAnalysis(parent),
                (child, parent) => child.ClassReferenceParent = parent);
        }
    
        public override string Name
        {
            get { return Syntax.ToName(); }
            set { Syntax = Syntax.WithName(value); }
        }

        public override IList<GenericParameterWithCodeAnalysis> GenericParameters
        {
            get { return genericParameters; }
            set { Syntax = Syntax.WithGenericParameters(value); }
        }

        public NameSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal IChildCollection<GenericParameterWithCodeAnalysis, TypeSyntax> GenericParameterList
        {
            get { return genericParameters; }
        }

        internal AttributeWithCodeAnalysis AttributeParent
        {
            get { return node.GetParentNode<AttributeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<AttributeWithCodeAnalysis, AttributeSyntax>(
                    value,
                    syntax => syntax.Name,
                    (parentSyntax, childSyntax) => parentSyntax.WithName(childSyntax));
            }
        }

        internal GenericParameterDeclarationWithCodeAnalysis GenericParameterDeclarationParent
        {
            get { return node.GetParentNode<GenericParameterDeclarationWithCodeAnalysis>(); }
            set
            {
                //node.SetParentNode<GenericParameterDeclarationWithCodeAnalysis, GenericParameterDeclarationSyntax>(
                //    value,
                //    syntax => syntax.Constraints.,
                //    (parentSyntax, childSyntax) => parentSyntax.)
            }
        }

        TypeSyntax IHasSyntax<TypeSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (NameSyntax)value; }
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
