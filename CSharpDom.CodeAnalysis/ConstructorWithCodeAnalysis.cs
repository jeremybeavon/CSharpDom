using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
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
        IHasNode<ConstructorDeclarationSyntax>
    {
        private readonly Node<ConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> node;
        private readonly AttributeListWrapper<ConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> attributes;
        private readonly MethodBodyNode<ConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> body;
        private readonly SeparatedSyntaxNodeList<
            ConstructorWithCodeAnalysis,
            ConstructorDeclarationSyntax,
            ConstructorParameterWithCodeAnalysis,
            ParameterSyntax> parameters;

        internal ConstructorWithCodeAnalysis()
        {
            node = new Node<ConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<ConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            body = new MethodBodyNode<ConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(
                node,
                syntax => syntax.Body,
                (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax));
            parameters = new SeparatedSyntaxNodeList<ConstructorWithCodeAnalysis, ConstructorDeclarationSyntax, ConstructorParameterWithCodeAnalysis, ParameterSyntax>(
                node,
                syntax => syntax.ParameterList.Parameters,
                (parentSyntax, childSyntax) => parentSyntax.WithParameterList(parentSyntax.ParameterList.WithParameters(childSyntax)),
                () => new ConstructorParameterWithCodeAnalysis());
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return body.Value; }
            set { body.Value = value; }
        }

        public override IType DeclaringType
        {
            get { return node.GetParent<IType>(); }
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

        internal Node<ConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> Node
        {
            get { return node; }
        }

        INode<ConstructorDeclarationSyntax> IHasNode<ConstructorDeclarationSyntax>.Node => node;
    }
}
