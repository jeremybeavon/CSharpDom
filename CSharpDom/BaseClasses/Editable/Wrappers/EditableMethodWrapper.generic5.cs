using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableMethodWrapper<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> :
        EditableMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>,
        IWrapper<IEditableMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableBasicType
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TTypeReference : IEditableTypeReference
        where TParameter : IEditableMethodParameter
    {
        public EditableMethodWrapper(IEditableMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method)
        {
            WrappedObject = method;
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

        public override IList<TGenericParameter> GenericParameters
        {
            get { return WrappedObject.GenericParameters; }
            set { WrappedObject.GenericParameters = value; }
        }

        public override string Name
        {
            get { return WrappedObject.Name; }
            set { WrappedObject.Name = value; }
        }

        public override IList<TParameter> Parameters
        {
            get { return WrappedObject.Parameters; }
            set { WrappedObject.Parameters = value; }
        }

        public override ICollection<TAttributeGroup> ReturnAttributes
        {
            get { return WrappedObject.ReturnAttributes; }
            set { WrappedObject.ReturnAttributes = value; }
        }

        public override TTypeReference ReturnType
        {
            get { return WrappedObject.ReturnType; }
            set { WrappedObject.ReturnType = value; }
        }

        public IEditableMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> WrappedObject { get; private set; }
    }
}