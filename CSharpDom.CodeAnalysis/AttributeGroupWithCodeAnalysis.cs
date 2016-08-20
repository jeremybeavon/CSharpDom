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
        IHasId
    {
        private readonly Guid internalId;
        private readonly SeparatedSyntaxListWrapper<AttributeWithCodeAnalysis, AttributeSyntax, AttributeGroupWithCodeAnalysis> attributes;
        private readonly Func<AttributeListSyntax> getAttributeList;
        private readonly Action<AttributeListSyntax> setAttributeList;

        internal AttributeGroupWithCodeAnalysis(AccessorWithCodeAnalysis parent)
        {
            getAttributeList = () => parent.AttributeList.GetChild(this);
            setAttributeList = syntax => parent.AttributeList.SetChild(this, syntax);
            attributes = new SeparatedSyntaxListWrapper<AttributeWithCodeAnalysis, AttributeSyntax, AttributeGroupWithCodeAnalysis>(
                () => getAttributeList().Attributes,
                list => setAttributeList(getAttributeList().WithAttributes(list)),
                () => new AttributeWithCodeAnalysis(this),
                this,
                (child, newParent) => child.Parent = newParent);
        }

        public override ICollection<AttributeWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set
            {
                setAttributeList(getAttributeList().WithAttributes(SyntaxFactory.SeparatedList(value.Select(node => node.Syntax))));
            }
        }

        public AttributeListSyntax Syntax { get; private set; }

        internal SeparatedSyntaxListWrapper<AttributeWithCodeAnalysis, AttributeSyntax, AttributeGroupWithCodeAnalysis> AttributeList
        {
             get { return attributes; }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
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
