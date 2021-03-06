﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
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
        IHasNode<DelegateDeclarationSyntax>
    {
        private readonly Node<DelegateTypeWithCodeAnalysis, DelegateDeclarationSyntax> node;
        private readonly AttributeListWrapper<DelegateTypeWithCodeAnalysis, DelegateDeclarationSyntax> attributes;
        private readonly GenericParameterDeclarationNodeList<DelegateTypeWithCodeAnalysis, DelegateDeclarationSyntax> genericParameters;
        private readonly SeparatedSyntaxNodeList<
            DelegateTypeWithCodeAnalysis,
            DelegateDeclarationSyntax,
            DelegateParameterWithCodeAnalysis,
            ParameterSyntax> parameters;
        private readonly CachedTypeReferenceNode<DelegateTypeWithCodeAnalysis, DelegateDeclarationSyntax> returnType;
        
        internal DelegateTypeWithCodeAnalysis()
        {
            node = new Node<DelegateTypeWithCodeAnalysis, DelegateDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<DelegateTypeWithCodeAnalysis, DelegateDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            genericParameters = new GenericParameterDeclarationNodeList<DelegateTypeWithCodeAnalysis, DelegateDeclarationSyntax>(
                node,
                syntax => syntax.TypeParameterList,
                (parentSyntax, childSyntax) => parentSyntax.WithTypeParameterList(childSyntax),
                syntax => syntax.ConstraintClauses,
                (parentSyntax, childSyntax) => parentSyntax.WithConstraintClauses(childSyntax));
            parameters = new SeparatedSyntaxNodeList<DelegateTypeWithCodeAnalysis, DelegateDeclarationSyntax, DelegateParameterWithCodeAnalysis, ParameterSyntax>(
                node,
                syntax => syntax.ParameterList.Parameters,
                (parentSyntax, childSyntax) => parentSyntax.WithParameterList(parentSyntax.ParameterList.WithParameters(childSyntax)),
                () => new DelegateParameterWithCodeAnalysis());
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

        INode<DelegateDeclarationSyntax> IHasNode<DelegateDeclarationSyntax>.Node => node;
    }
}
