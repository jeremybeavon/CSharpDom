using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableDelegateTypeWrapper<TAttributeGroup, TGenericParameter, TTypeReference, TParameter> :
        EditableDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter>,
        IWrapper<IEditableDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter>>
        where TAttributeGroup : IEditableAttributeGroup
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TTypeReference : IEditableTypeReference
        where TParameter : IEditableDelegateParameter
    {
        public EditableDelegateTypeWrapper(IEditableDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter> delegateType)
        {
            WrappedObject = delegateType;
        }

        public override ICollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
            set { WrappedObject.Attributes = value; }
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

        public override TTypeReference ReturnType
        {
            get { return WrappedObject.ReturnType; }
            set { WrappedObject.ReturnType = value; }
        }

        public IEditableDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter> WrappedObject { get; private set; }
    }
}