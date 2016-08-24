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
        private SeparatedSyntaxListWrapper<
            ClassReferenceWithCodeAnalysis,
            TypeSyntax,
            GenericParameterWithCodeAnalysis,
            TypeSyntax> genericParameters;

        //public ClassReferenceWithCodeAnalysis(string name)
        //    : this(new DetachedParent<NameSyntax>(SyntaxFactory.IdentifierName(name)))
        //{
        //}

        internal ClassReferenceWithCodeAnalysis(AttributeWithCodeAnalysis parent)
        {
            ParentAttribute = parent;
            /*genericParameters = new SeparatedSyntaxListWrapper<ClassReferenceWithCodeAnalysis, TypeSyntax, GenericParameterWithCodeAnalysis, TypeSyntax>(
                node,
                syntax => node.Syntax.GetGenericParameters(),
                list => node.Syntax = node.Syntax.SetGenericParameters(list),
                newParent => new GenericParameterWithCodeAnalysis(newParent),
                (child, newParent) => child.ClassReferenceParent = newParent);*/
        }
    
        public NameSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        public override string Name
        {
            get { return node.Syntax.ToName(); }
            set { node.Syntax = SyntaxFactory.IdentifierName(value); }
        }

        public override IList<GenericParameterWithCodeAnalysis> GenericParameters
        {
            get { return genericParameters; }
            set { node.Syntax = node.Syntax.SetGenericParameters(SyntaxFactory.SeparatedList(value.Select(node => node.Syntax))); }
        }

        internal IChildCollection<GenericParameterWithCodeAnalysis, TypeSyntax> GenericParameterList
        {
            get { return genericParameters; }
        }

        internal AttributeWithCodeAnalysis ParentAttribute
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
