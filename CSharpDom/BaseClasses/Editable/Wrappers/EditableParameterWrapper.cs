using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableParameterWrapper<TAttributeGroup, TTypeReference> :
        EditableParameter<TAttributeGroup, TTypeReference>,
        IWrapper<IEditableParameter<TAttributeGroup, TTypeReference>>
        where TAttributeGroup : IEditableAttributeGroup
        where TTypeReference : IEditableTypeReference
    {
        public EditableParameterWrapper(IEditableParameter<TAttributeGroup, TTypeReference> parameter)
        {
            WrappedObject = parameter;
        }

        public override ICollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
            set { WrappedObject.Attributes = value; }
        }

        public override string Name
        {
            get { return WrappedObject.Name; }
            set { WrappedObject.Name = value; }
        }

        public override TTypeReference ParameterType
        {
            get { return WrappedObject.ParameterType; }
            set { WrappedObject.ParameterType = value; }
        }

        public IEditableParameter<TAttributeGroup, TTypeReference> WrappedObject { get; private set; }
    }
}