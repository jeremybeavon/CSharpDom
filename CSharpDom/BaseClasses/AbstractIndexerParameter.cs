using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractIndexerParameter<TAttributeGroup, TTypeReference> :
        AbstractParameter<TAttributeGroup, TTypeReference>,
        IIndexerParameter<TAttributeGroup, TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TTypeReference : ITypeReference
    {
        public abstract IndexerParameterModifier Modifier { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitIndexerParameter(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitIndexerParameterChildren(this, visitor);
        }
    }
}
