using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ParameterWithCodeAnalysis :
        EditableParameter<AttributeGroupWithCodeAnalysis, ITypeReferenceWithCodeAnalysis>,
        IHasSyntax<ParameterSyntax>,
        IHasNode<ParameterSyntax>
    {
        private readonly Node<ParameterWithCodeAnalysis, ParameterSyntax> node;
        private readonly AttributeListWrapper<ParameterWithCodeAnalysis, ParameterSyntax> attributes;
        private readonly CachedTypeReferenceNode<ParameterWithCodeAnalysis, ParameterSyntax> parameterType;
        
        internal ParameterWithCodeAnalysis(ITypeReferenceWithCodeAnalysis type, string name)
            : this()
        {
            Syntax = SyntaxFactory.Parameter(
                SyntaxFactory.List<AttributeListSyntax>(),
                SyntaxFactory.TokenList(),
                type.Syntax,
                SyntaxFactory.Identifier(name),
                null);
        }

        internal ParameterWithCodeAnalysis()
        {
            node = new Node<ParameterWithCodeAnalysis, ParameterSyntax>(this);
            attributes = new AttributeListWrapper<ParameterWithCodeAnalysis, ParameterSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            parameterType = new CachedTypeReferenceNode<ParameterWithCodeAnalysis, ParameterSyntax>(
                node,
                syntax => syntax.Type,
                (parentSyntax, childSyntax) => parentSyntax.WithType(childSyntax));
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override string Name
        {
            get { return Syntax.Identifier.Text; }
            set { Syntax = Syntax.WithIdentifier(SyntaxFactory.Identifier(value)); }
        }

        public override ITypeReferenceWithCodeAnalysis ParameterType
        {
            get { return parameterType.Value; }
            set { parameterType.Value = value; }
        }
        
        public ParameterSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal Node<ParameterWithCodeAnalysis, ParameterSyntax> Node
        {
            get { return node; }
        }

        INode<ParameterSyntax> IHasNode<ParameterSyntax>.Node => node;

        private static ConversionOperatorDeclarationSyntax WithParameter(
            ConversionOperatorDeclarationSyntax parentSyntax,
            ParameterSyntax childSyntax)
        {
            return parentSyntax.WithParameterList(
                parentSyntax.ParameterList.WithParameters(SyntaxFactory.SeparatedList(new[] { childSyntax })));
        }

        private static MethodDeclarationSyntax WithParameter(
            MethodDeclarationSyntax parentSyntax,
            ParameterSyntax childSyntax)
        {
            return parentSyntax.WithParameterList(
                parentSyntax.ParameterList.WithParameters(SyntaxFactory.SeparatedList(new[] { childSyntax })));
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitParameterWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
