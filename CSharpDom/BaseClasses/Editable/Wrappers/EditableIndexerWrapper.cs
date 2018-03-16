using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableIndexerWrapper<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> :
        EditableIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>,
        IWrapper<IEditableIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableBasicType
        where TTypeReference : IEditableTypeReference
        where TParameter : IEditableIndexerParameter
        where TAccessor : IEditableAccessor
    {
        public EditableIndexerWrapper(IEditableIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            WrappedObject = indexer;
        }

        public override ICollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
            set { WrappedObject.Attributes = value; }
        }

        public override TDeclaringType DeclaringType
        {
            get { return WrappedObject.DeclaringType; }
            set { WrappedObject.DeclaringType = value; }
        }

        public override TAccessor GetAccessor
        {
            get { return WrappedObject.GetAccessor; }
            set { WrappedObject.GetAccessor = value; }
        }

        public override TTypeReference IndexerType
        {
            get { return WrappedObject.IndexerType; }
            set { WrappedObject.IndexerType = value; }
        }

        public override IList<TParameter> Parameters
        {
            get { return WrappedObject.Parameters; }
            set { WrappedObject.Parameters = value; }
        }

        public override TAccessor SetAccessor
        {
            get { return WrappedObject.SetAccessor; }
            set { WrappedObject.SetAccessor = value; }
        }

        public IEditableIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> WrappedObject { get; private set; }
    }
}