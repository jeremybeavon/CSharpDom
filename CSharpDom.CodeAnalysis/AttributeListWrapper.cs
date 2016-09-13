using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class AttributeListWrapper<TParentNode, TParentSyntax> :
        SyntaxListWrapper<TParentNode, TParentSyntax, AttributeGroupWithCodeAnalysis, AttributeListSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TParentSyntax : class
    {
        private readonly Node<TParentNode, TParentSyntax> node;
        private readonly Func<TParentSyntax, SyntaxList<AttributeListSyntax>, TParentSyntax> createList;
        private readonly FilteredAttributeList attributes;
        private readonly FilteredAttributeList targetedAttributes;

        public AttributeListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<AttributeListSyntax>> getList,
            Func<TParentSyntax, SyntaxList<AttributeListSyntax>, TParentSyntax> createList)
            : base(node, getList, createList, () => new AttributeGroupWithCodeAnalysis())
        {
            this.node = node;
            this.createList = createList;
            attributes = new FilteredAttributeList(this, attribute => attribute.Syntax.Target == null);
            targetedAttributes = new FilteredAttributeList(this, attribute => attribute.Syntax.Target != null);
        }

        public ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { node.Syntax = createList(node.Syntax, ToAttributes(value.Concat(targetedAttributes))); }
        }

        public ICollection<AttributeGroupWithCodeAnalysis> TargetedAttributes
        {
            get { return targetedAttributes; }
            set { node.Syntax = createList(node.Syntax, ToAttributes(attributes.Concat(value))); }
        }

        private SyntaxList<AttributeListSyntax> ToAttributes(IEnumerable<AttributeGroupWithCodeAnalysis> attributes)
        {
            return SyntaxFactory.List(attributes.Select(item => item.Syntax));
        }
    }
}
