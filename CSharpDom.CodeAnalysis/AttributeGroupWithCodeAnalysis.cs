using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    public class AttributeGroupWithCodeAnalysis :
        EditableAttributeGroup<AttributeWithCodeAnalysis>,
        IHasSyntax<AttributeListSyntax>,
        IHasParent<AttributeGroupWithCodeAnalysis, AttributeListSyntax>,
        IHasChild<SeparatedSyntaxList<AttributeSyntax>>,
        IHasId
    {
        private readonly Guid internalId;
        private IHasChildWithId<AttributeGroupWithCodeAnalysis, AttributeListSyntax> parent;
        private ICollection<AttributeWithCodeAnalysis> attributes;

        internal AttributeGroupWithCodeAnalysis(IHasChildWithId<AttributeGroupWithCodeAnalysis, AttributeListSyntax> parent)
        {
            this.parent = parent;
            attributes = new SeparatedSyntaxListWrapper<AttributeWithCodeAnalysis, AttributeSyntax>(
                this,
                list => new AttributeWithCodeAnalysis(list));
        }

        public override ICollection<AttributeWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set
            {
                parent.SetChild(
                    this,
                    parent.GetChild(this).WithAttributes(SyntaxFactory.SeparatedList(value.Select(node => node.Syntax))));
            }
        }

        public AttributeListSyntax Syntax { get; private set; }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }

        IHasChildWithId<AttributeGroupWithCodeAnalysis, AttributeListSyntax> IHasParent<AttributeGroupWithCodeAnalysis, AttributeListSyntax>.Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        SeparatedSyntaxList<AttributeSyntax> IHasChild<SeparatedSyntaxList<AttributeSyntax>>.Child
        {
            get { return parent.GetChild(this).Attributes; }
            set
            {
                throw new NotImplementedException();
            }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitAttributeWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
