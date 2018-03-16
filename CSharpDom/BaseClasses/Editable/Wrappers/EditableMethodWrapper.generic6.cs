using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableMethodWrapper<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> :
        EditableMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>,
        IWrapper<IEditableMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TTypeReference : IEditableTypeReference
        where TParameter : IEditableMethodParameter
        where TMethodBody : IEditableMethodBody
    {
        public EditableMethodWrapper(IEditableMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            WrappedObject = method;
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

        public override IList<TGenericParameter> GenericParameters
        {
            get { return WrappedObject.GenericParameters; }
            set { WrappedObject.GenericParameters = value; }
        }

        public override bool IsAsync
        {
            get { return WrappedObject.IsAsync; }
            set { WrappedObject.IsAsync = value; }
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
            get { return ReturnAttributes; }
            set { WrappedObject.ReturnAttributes = value; }
        }

        public override TTypeReference ReturnType
        {
            get { return WrappedObject.ReturnType; }
            set { WrappedObject.ReturnType = value; }
        }

        public IEditableMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> WrappedObject { get; private set; }
    }
}