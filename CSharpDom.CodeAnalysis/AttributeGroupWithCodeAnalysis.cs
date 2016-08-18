using System.Collections.Generic;
using CSharpDom.BaseClasses;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public class AttributeGroupWithCodeAnalysis :
        AbstractAttributeGroup<IAttributeWithCodeAnalysis>,
        IHasSyntax<AttributeListSyntax>
    {
        private readonly IAttributeWithCodeAnalysis attribute;

        internal AttributeGroupWithCodeAnalysis(AttributeListSyntax attribute)
        {
        }

        public override IReadOnlyCollection<IAttributeWithCodeAnalysis> Attributes
        {
            get { return new IAttributeWithCodeAnalysis[] { attribute }; }
        }

        public AttributeListSyntax Syntax { get; private set; }
        
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
