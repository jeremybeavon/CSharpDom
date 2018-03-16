using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableConstructorWrapper<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> :
        EditableConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>,
        IWrapper<IEditableConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TParameter : IEditableConstructorParameter
        where TMethodBody : IEditableMethodBody
    {
        public EditableConstructorWrapper(IEditableConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
        {
            WrappedObject = constructor;
        }

        public override ICollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
            set { WrappedObject.Attributes = value; }
        }

        public override TMethodBody Body
        {
            get { return WrappedObject.Body; }
            set { WrappedObject.Body = value; }
        }

        public override TDeclaringType DeclaringType
        {
            get { return WrappedObject.DeclaringType; }
            set { WrappedObject.DeclaringType = value; }
        }

        public override IList<TParameter> Parameters
        {
            get { return WrappedObject.Parameters; }
            set { WrappedObject.Parameters = value; }
        }

        public IEditableConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> WrappedObject { get; private set; }
    }
}