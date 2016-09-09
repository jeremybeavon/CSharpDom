using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableSealedClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> :
        EditableIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>,
        ISealedClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : ISealedType
        where TTypeReference : ITypeReference
        where TParameter : IIndexerParameter
        where TAccessor : IClassAccessor
    {
        public abstract SealedClassIndexerInheritanceModifier InheritanceModifier { get; set; }
        
        public abstract ClassMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitSealedClassIndexer(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitSealedClassIndexerChildren(this, visitor);
        }
    }
}
