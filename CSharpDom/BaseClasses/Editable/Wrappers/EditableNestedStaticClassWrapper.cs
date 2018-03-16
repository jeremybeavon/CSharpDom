using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableNestedStaticClassWrapper<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> :
        EditableNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>,
        IWrapper<IEditableNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TEventCollection : IEditableStaticClassEventCollection
        where TPropertyCollection : IEditableStaticClassPropertyCollection
        where TMethodCollection : IEditableNestedStaticClassMethodCollection
        where TFieldCollection : IEditableStaticClassFieldCollection
        where TNestedClassCollection : IEditableStaticClassNestedClassCollection
        where TNestedDelegate : IEditableStaticClassNestedDelegate
        where TNestedEnum : IEditableStaticClassNestedEnum
        where TNestedInterface : IEditableStaticClassNestedInterface
        where TNestedStructCollection : IEditableStaticClassNestedStructCollection
        where TStaticConstructor : IEditableStaticConstructor
    {
        public EditableNestedStaticClassWrapper(IEditableNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> @class)
        {
            WrappedObject = @class;
        }

        public override ICollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
            set { WrappedObject.Attributes = value; }
        }

        public override TNestedClassCollection Classes
        {
            get { return WrappedObject.Classes; }
            set { WrappedObject.Classes = value; }
        }

        public override TDeclaringType DeclaringType
        {
            get { return WrappedObject.DeclaringType; }
            set { WrappedObject.DeclaringType = value; }
        }

        public override ICollection<TNestedDelegate> Delegates
        {
            get { return WrappedObject.Delegates; }
            set { WrappedObject.Delegates = value; }
        }

        public override ICollection<TNestedEnum> Enums
        {
            get { return WrappedObject.Enums; }
            set { WrappedObject.Enums = value; }
        }

        public override TEventCollection Events
        {
            get { return WrappedObject.Events; }
            set { WrappedObject.Events = value; }
        }

        public override TFieldCollection Fields
        {
            get { return WrappedObject.Fields; }
            set { WrappedObject.Fields = value; }
        }

        public override IList<TGenericParameter> GenericParameters
        {
            get { return WrappedObject.GenericParameters; }
            set { WrappedObject.GenericParameters = value; }
        }

        public override ICollection<TNestedInterface> Interfaces
        {
            get { return WrappedObject.Interfaces; }
            set { WrappedObject.Interfaces = value; }
        }

        public override TMethodCollection Methods
        {
            get { return WrappedObject.Methods; }
            set { WrappedObject.Methods = value; }
        }

        public override string Name
        {
            get { return WrappedObject.Name; }
            set { WrappedObject.Name = value; }
        }

        public override TPropertyCollection Properties
        {
            get { return WrappedObject.Properties; }
            set { WrappedObject.Properties = value; }
        }

        public override TStaticConstructor StaticConstructor
        {
            get { return WrappedObject.StaticConstructor; }
            set { WrappedObject.StaticConstructor = value; }
        }

        public override TNestedStructCollection Structs
        {
            get { return WrappedObject.Structs; }
            set { WrappedObject.Structs = value; }
        }

        public IEditableNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> WrappedObject { get; private set; }
    }
}