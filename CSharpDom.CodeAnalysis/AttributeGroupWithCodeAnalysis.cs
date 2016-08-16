using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public class AttributeGroupWithCodeAnalysis :
        AbstractAttributeGroup<IAttributeWithCodeAnalysis>
    {
        private readonly IAttributeWithCodeAnalysis attribute;

        internal AttributeGroupWithCodeAnalysis(AttributeListSyntax attribute)
        {
        }

        public override IReadOnlyCollection<IAttributeWithCodeAnalysis> Attributes
        {
            get { return new IAttributeWithCodeAnalysis[] { attribute }; }
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
