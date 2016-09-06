using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticTypeWithCodeAnalysis :
        EditableStaticType<
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            StaticClassEventCollectionWithCodeAnalysis,
            StaticClassPropertyWithCodeAnalysis,
            StaticClassMethodCollectionWithCodeAnalysis,
            IStaticClassFieldCollection,
            IStaticClassNestedClassCollection,
            IStaticClassNestedDelegate,
            IStaticClassNestedEnum,
            IStaticClassNestedInterfaceCollection,
            IStaticClassNestedStructCollection,
            IStaticConstructor>,
        IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly Node<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax> node;
        private readonly AttributeListWrapper<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax> attributes;
        private readonly SimpleStaticTypeMemberListWrapper<
            ConversionOperatorWithCodeAnalysis,
            ConversionOperatorDeclarationSyntax> conversionOperators;
        private readonly GenericParameterDeclarationListWrapper<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax> genericParameters;
        private readonly SimpleStaticTypeMemberListWrapper<
            OperatorOverloadWithCodeAnalysis,
            OperatorDeclarationSyntax> operatorOverloads;
        private readonly MemberList<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax> members;

        private StaticTypeWithCodeAnalysis()
        {
            node = new Node<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                parent => new AttributeGroupWithCodeAnalysis(parent),
                (child, parent) => child.StaticClassParent = parent);
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public ClassDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal Node<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax> Node
        {
            get { return node; }
        }

        internal MemberList<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax> Members
        {
            get { return members; }
        }

        internal IAttributeCollection AttributeList
        {
            get { return attributes; }
        }
    }
}
