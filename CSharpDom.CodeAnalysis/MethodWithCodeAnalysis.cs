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
    public sealed class MethodWithCodeAnalysis :
        EditableMethod<
            AttributeGroupWithCodeAnalysis,
            IBasicType,
            GenericParameterDeclarationWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            MethodParameterWithCodeAnalysis>,
        IHasSyntax<MethodDeclarationSyntax>,
        ISimpleMember
    {
        private readonly object method;
        private readonly Node<MethodWithCodeAnalysis, MethodDeclarationSyntax> node;
        private readonly AttributeListWrapper<MethodWithCodeAnalysis, MethodDeclarationSyntax> attributes;
        private readonly GenericParameterDeclarationListWrapper<MethodWithCodeAnalysis, MethodDeclarationSyntax> genericParameters;
        private readonly SeparatedSyntaxListWrapper<
            MethodWithCodeAnalysis,
            MethodDeclarationSyntax,
            MethodParameterWithCodeAnalysis,
            ParameterSyntax> parameters;
        private readonly CachedTypeReferenceNode<MethodWithCodeAnalysis, MethodDeclarationSyntax> returnType;
        
        internal MethodWithCodeAnalysis(object method)
        {
            node = new Node<MethodWithCodeAnalysis, MethodDeclarationSyntax>(this);
            this.method = method;
            attributes = new AttributeListWrapper<MethodWithCodeAnalysis, MethodDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            genericParameters = new GenericParameterDeclarationListWrapper<MethodWithCodeAnalysis, MethodDeclarationSyntax>(
                node,
                syntax => syntax.TypeParameterList,
                (parentSyntax, childSyntax) => parentSyntax.WithTypeParameterList(childSyntax),
                syntax => syntax.ConstraintClauses,
                (parentSyntax, childSyntax) => parentSyntax.WithConstraintClauses(childSyntax));
            parameters = new SeparatedSyntaxListWrapper<MethodWithCodeAnalysis, MethodDeclarationSyntax, MethodParameterWithCodeAnalysis, ParameterSyntax>(
                node,
                syntax => syntax.ParameterList.Parameters,
                (parentSyntax, childSyntax) => parentSyntax.WithParameterList(parentSyntax.ParameterList.WithParameters(childSyntax)),
                () => new MethodParameterWithCodeAnalysis());
            returnType = new CachedTypeReferenceNode<MethodWithCodeAnalysis, MethodDeclarationSyntax>(
                node,
                syntax => syntax.ReturnType,
                (parentSyntax, childSyntax) => parentSyntax.WithReturnType(childSyntax));
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Attributes; }
            set { attributes.Attributes = value; }
        }

        public override IBasicType DeclaringType
        {
            get { return node.GetParentNode<IBasicType>(); }
            set { throw new NotSupportedException(); }
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

        public override IList<MethodParameterWithCodeAnalysis> Parameters
        {
            get { return parameters; }
            set
            {
                Syntax = Syntax.WithParameterList(
                    SyntaxFactory.ParameterList(SyntaxFactory.SeparatedList(value.Select(node => node.Syntax))));
            }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> ReturnAttributes
        {
            get { return attributes.TargetedAttributes; }
            set { attributes.TargetedAttributes = value; }
        }

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return returnType.Value; }
            set { returnType.Value = value; }
        }

        public MethodDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal Node<MethodWithCodeAnalysis, MethodDeclarationSyntax> Node
        {
            get { return node; }
        }
        
        T ISimpleMember.Member<T>()
        {
            return (T)method;
        }
    }
}
