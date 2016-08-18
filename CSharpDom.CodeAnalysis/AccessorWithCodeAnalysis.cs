using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AccessorWithCodeAnalysis :
        EditableAccessor<AttributeGroupWithCodeAnalysis, MethodBodyWithCodeAnalysis>,
        IReplaceSyntaxList<AttributeListSyntax>
    {
        private readonly ICollection<AttributeGroupWithCodeAnalysis> attributes;
        private AccessorDeclarationSyntax syntax;

        public AccessorWithCodeAnalysis(AccessorDeclarationSyntax syntax)
        {
            Syntax = syntax;
            attributes = new SyntaxListWrapper<AttributeGroupWithCodeAnalysis, AttributeListSyntax>(
                this,
                () => syntax.AttributeLists,
                list => new AttributeGroupWithCodeAnalysis(list));
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set
            {
                syntax = syntax.WithAttributeLists(new SyntaxList<AttributeListSyntax>().AddRange(value.Select(node => node.Syntax)));
            }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return body.Value; }
        }

        public AccessorDeclarationSyntax Syntax { get; private set; }

        void IReplaceSyntaxList<AttributeListSyntax>.ReplaceSyntaxList(SyntaxList<AttributeListSyntax> list)
        {
            syntax = syntax.WithAttributeLists(list);
        }
    }
}
