using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> :
        EditableNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>,
        IClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TGenericParameter : IGenericParameterDeclaration
        where TInterfaceReference : IInterfaceReference
        where TEvent : IInterfaceEvent
        where TProperty : IInterfaceProperty
        where TIndexer : IInterfaceIndexer
        where TMethod : IInterfaceMethod
    {
        public abstract ClassMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassNestedInterface(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassNestedInterfaceChildren(this, visitor);
        }
    }
}
