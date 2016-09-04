using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ConstructorWithCodeAnalysis :
        EditableConstructor<
            AttributeGroupWithCodeAnalysis,
            IType,
            ConstructorParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<ConstructorDeclarationSyntax>,
        ISimpleMember
    {
        private readonly object constructor;
        private readonly Node<ConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> node;
        private readonly AttributeListWrapper<ConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> attributes;
        private readonly SeparatedSyntaxListWrapper<
            ConstructorWithCodeAnalysis,
            ConstructorDeclarationSyntax,
            ConstructorParameterWithCodeAnalysis,
            ParameterSyntax> parameters;

        internal ConstructorWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, ClassConstructorWithCodeAnalysis constructor)
            : this(constructor)
        {
            ClassParent = parent;
        }

        private ConstructorWithCodeAnalysis(object constructor)
        {
            node = new Node<ConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(this);
            this.constructor = constructor;
            attributes = new AttributeListWrapper<ConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                parent => new AttributeGroupWithCodeAnalysis(parent),
                (child, parent) => child.ConstructorParent = parent);
            parameters = new SeparatedSyntaxListWrapper<ConstructorWithCodeAnalysis, ConstructorDeclarationSyntax, ConstructorParameterWithCodeAnalysis, ParameterSyntax>(
                node,
                syntax => syntax.ParameterList.Parameters,
                (parentSyntax, childSyntax) => parentSyntax.WithParameterList(parentSyntax.ParameterList.WithParameters(childSyntax)),
                parent => new ConstructorParameterWithCodeAnalysis(parent),
                (child, parent) => child.Parameter.ConstructorParent = parent);
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override IType DeclaringType
        {
            get { return base.DeclaringType; }
            set { throw new NotSupportedException(); }
        }

        public override IList<ConstructorParameterWithCodeAnalysis> Parameters
        {
            get { return parameters; }
            set
            {
                Syntax = Syntax.WithParameterList(
                    SyntaxFactory.ParameterList(SyntaxFactory.SeparatedList(value.Select(node => node.Syntax))));
            }
        }

        public ConstructorDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal IAttributeCollection AttributeList
        {
            get { return attributes; }
        }

        internal IChildCollection<ConstructorParameterWithCodeAnalysis, ParameterSyntax> ParameterList
        {
            get { return parameters; }
        }

        internal ClassTypeWithCodeAnalysis ClassParent
        {
            get { return node.GetParentNode<ClassTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                    value,
                    parent => parent.ConstructorList);
            }
        }

        T ISimpleMember.Member<T>()
        {
            return (T)constructor;
        }
    }
}
