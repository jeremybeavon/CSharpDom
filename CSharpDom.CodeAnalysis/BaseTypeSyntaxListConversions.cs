using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class BaseTypeSyntaxListConversions<TParent, TParentSyntax> :
        IWrappedListConversions<BaseTypeSyntax, NameSyntax>,
        IChildSyntaxListConversions<TParentSyntax, SeparatedSyntaxList<BaseTypeSyntax>>
        where TParentSyntax : TypeDeclarationSyntax
    {
        private readonly Func<TParentSyntax, BaseListSyntax, TParentSyntax> createList;
        private readonly IChildSyntaxList<TParentSyntax, BaseTypeSyntax> list;

        public BaseTypeSyntaxListConversions(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, BaseListSyntax, TParentSyntax> createList)
        {
            this.createList = createList;
            list = ListFactory.CreateChildSyntaxList(node, this);
        }

        public IChildSyntaxList<TParentSyntax, BaseTypeSyntax> List => list;

        public TParentSyntax CreateList(TParentSyntax parentSyntax, SeparatedSyntaxList<BaseTypeSyntax> childSyntax)
        {
            return createList(parentSyntax, (parentSyntax.BaseList ?? SyntaxFactory.BaseList()).WithTypes(childSyntax));
        }

        public SeparatedSyntaxList<BaseTypeSyntax> GetList(TParentSyntax syntax)
        {
            return syntax?.BaseList?.Types ?? SyntaxFactory.SeparatedList<BaseTypeSyntax>();
        }

        public NameSyntax ToChild(BaseTypeSyntax parent)
        {
            return (NameSyntax)parent.Type;
        }

        public BaseTypeSyntax ToParent(NameSyntax child)
        {
            return list.FirstOrDefault(typeSyntax => typeSyntax.Type == child) ??
                SyntaxFactory.SimpleBaseType(child);
        }
    }
}
