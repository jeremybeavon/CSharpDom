using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableIndexerParameter<TAttributeGroup, TTypeReference> :
        EditableParameter<TAttributeGroup, TTypeReference>,
        IIndexerParameter<TAttributeGroup, TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TTypeReference : ITypeReference
    {
        public abstract IndexerParameterModifier Modifier { get; set; }

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
