using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AccessorWithBodyWithCodeAnalysis :
        EditableAccessor<AttributeGroupWithCodeAnalysis, MethodBodyWithCodeAnalysis>,
        IHasSyntax<AccessorDeclarationSyntax>
    {
        private readonly AccessorWithCodeAnalysis accessor;
        private readonly MethodBodyNode<AccessorWithCodeAnalysis, AccessorDeclarationSyntax> body;

        public AccessorWithBodyWithCodeAnalysis(AccessorType accessorType, MethodBodyWithCodeAnalysis body)
            : this(new AccessorWithCodeAnalysis(SyntaxFactory.AccessorDeclaration(AccessorWithCodeAnalysis.GetSyntax(accessorType), body.Syntax)))
        {
        }

        internal AccessorWithBodyWithCodeAnalysis(AccessorWithCodeAnalysis accessor)
        {
            this.accessor = accessor;
            body = new MethodBodyNode<AccessorWithCodeAnalysis, AccessorDeclarationSyntax>(
                accessor.Node,
                syntax => syntax?.Body,
                (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax));
        }

        public AccessorWithCodeAnalysis Accessor
        {
            get { return accessor; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return accessor.Attributes; }
            set { accessor.Attributes = value; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return body.Value; }
            set { body.Value = value; }
        }

        public AccessorDeclarationSyntax Syntax
        {
            get { return accessor.Syntax; }
            set { accessor.Syntax = value; }
        }
    }
}
