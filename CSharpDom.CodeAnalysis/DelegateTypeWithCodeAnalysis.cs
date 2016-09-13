using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    public sealed class DelegateTypeWithCodeAnalysis :
        EditableDelegateType<
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            DelegateParameterWithCodeAnalysis>,
        IHasSyntax<DelegateDeclarationSyntax>,
        ISimpleMember
    {
        private readonly object @delegate;
        private readonly Node<DelegateTypeWithCodeAnalysis, DelegateDeclarationSyntax> node;
        private readonly AttributeListWrapper<DelegateTypeWithCodeAnalysis, DelegateDeclarationSyntax> attributes;
        private readonly GenericParameterDeclarationListWrapper<DelegateTypeWithCodeAnalysis, DelegateDeclarationSyntax> genericParameters;
        private readonly SeparatedSyntaxListWrapper<
            DelegateTypeWithCodeAnalysis,
            DelegateDeclarationSyntax,
            DelegateParameterWithCodeAnalysis,
            ParameterSyntax> parameters;
        private readonly CachedTypeReferenceNode<DelegateTypeWithCodeAnalysis, DelegateDeclarationSyntax> returnType;

        internal DelegateTypeWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, ClassNestedDelegateWithCodeAnalysis @delegate)
            : this(@delegate)
        {
            ClassParent = parent;
        }

        internal DelegateTypeWithCodeAnalysis(StaticTypeWithCodeAnalysis parent, StaticClassNestedDelegateWithCodeAnalysis @delegate)
            : this(@delegate)
        {
            StaticClassParent = parent;
        }

        internal DelegateTypeWithCodeAnalysis(StructTypeWithCodeAnalysis parent, StructNestedDelegateWithCodeAnalysis @delegate)
            : this(@delegate)
        {
            StructParent = parent;
        }

        private DelegateTypeWithCodeAnalysis(object @delegate)
        {
            node = new Node<DelegateTypeWithCodeAnalysis, DelegateDeclarationSyntax>(this);
            this.@delegate = @delegate;
            attributes = new AttributeListWrapper<DelegateTypeWithCodeAnalysis, DelegateDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                parent => new AttributeGroupWithCodeAnalysis(parent),
                (child, parent) => child.DelegateParent = parent);
            genericParameters = new GenericParameterDeclarationListWrapper<DelegateTypeWithCodeAnalysis, DelegateDeclarationSyntax>(
                node,
                syntax => syntax.TypeParameterList,
                (parentSyntax, childSyntax) => parentSyntax.WithTypeParameterList(childSyntax),
                syntax => syntax.ConstraintClauses,
                (parentSyntax, childSyntax) => parentSyntax.WithConstraintClauses(childSyntax),
                parent => new GenericParameterDeclarationWithCodeAnalysis(parent),
                (child, parent) => child.DelegateParent = parent);
            parameters = new SeparatedSyntaxListWrapper<DelegateTypeWithCodeAnalysis, DelegateDeclarationSyntax, DelegateParameterWithCodeAnalysis, ParameterSyntax>(
                node,
                syntax => syntax.ParameterList.Parameters,
                (parentSyntax, childSyntax) => parentSyntax.WithParameterList(parentSyntax.ParameterList.WithParameters(childSyntax)),
                parent => new DelegateParameterWithCodeAnalysis(parent),
                (child, parent) => child.Parameter.DelegateParent = parent);
            returnType = new CachedTypeReferenceNode<DelegateTypeWithCodeAnalysis, DelegateDeclarationSyntax>(
                node,
                syntax => syntax.ReturnType,
                (parentSyntax, childSyntax) => parentSyntax.WithReturnType(childSyntax));
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return genericParameters; }
            set { genericParameters.ReplaceList(value); }
        }

        public override string Name
        {
            get { return Syntax.Identifier.Text; }
            set { Syntax = Syntax.WithIdentifier(SyntaxFactory.Identifier(value)); }
        }

        public override IList<DelegateParameterWithCodeAnalysis> Parameters
        {
            get { return parameters; }
            set { parameters.ReplaceList(value); }
        }

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return returnType.Value; }
            set { returnType.Value = value; }
        }

        public DelegateDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal Node<DelegateTypeWithCodeAnalysis, DelegateDeclarationSyntax> Node
        {
            get { return node; }
        }

        internal IAttributeCollection AttributeList
        {
            get { return attributes; }
        }

        internal IGenericParameterCollection GenericParameterList
        {
            get { return genericParameters; }
        }

        internal IChildCollection<DelegateParameterWithCodeAnalysis, ParameterSyntax> ParameterList
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
                    parent => parent.DelegateList);
            }
        }

        internal StaticTypeWithCodeAnalysis StaticClassParent
        {
            get { return node.GetParentNode<StaticTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                    value,
                    parent => parent.DelegateList);
            }
        }

        internal StructTypeWithCodeAnalysis StructParent
        {
            get { return node.GetParentNode<StructTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<StructTypeWithCodeAnalysis, StructDeclarationSyntax>(
                    value,
                    parent => parent.DelegateList);
            }
        }

        T ISimpleMember.Member<T>()
        {
            return (T)@delegate;
        }
    }
}
