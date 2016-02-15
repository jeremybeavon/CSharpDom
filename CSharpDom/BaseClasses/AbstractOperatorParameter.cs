using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractOperatorParameter<TAttributeGroup, TTypeReference> :
        AbstractParameter<TAttributeGroup, TTypeReference>,
        IOperatorParameter<TAttributeGroup, TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TTypeReference : ITypeReference
    {
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitOperatorParameter(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitOperatorParameterChildren(this, visitor);
        }
    }
}
