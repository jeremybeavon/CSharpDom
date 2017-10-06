using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> :
        EditableIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>,
        IClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TTypeReference : ITypeReference
        where TParameter : IIndexerParameter
        where TAccessor : IClassAccessor
    {
        public abstract IndexerInheritanceModifier InheritanceModifier { get; set; }
        
        public abstract ClassMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassIndexer(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassIndexerChildren(this, visitor);
        }
    }
}
