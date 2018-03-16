using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableStaticClassWrapper<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> :
        EditableStaticClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>,
        IWrapper<IEditableStaticClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>>
        where TNamespace : IEditableNamespace
        where TDocument : IEditableDocument
        where TProject : IEditableProject
        where TSolution : IEditableSolution
        where TAttributeGroup : IEditableAttributeGroup
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TEventCollection : IEditableStaticClassEventCollection
        where TPropertyCollection : IEditableStaticClassPropertyCollection
        where TMethodCollection : IEditableStaticClassMethodCollection
        where TFieldCollection : IEditableStaticClassFieldCollection
        where TNestedClassCollection : IEditableStaticClassNestedClassCollection
        where TNestedDelegate : IEditableStaticClassNestedDelegate
        where TNestedEnum : IEditableStaticClassNestedEnum
        where TNestedInterface : IEditableStaticClassNestedInterface
        where TNestedStructCollection : IEditableStaticClassNestedStructCollection
        where TStaticConstructor : IEditableStaticConstructor
    {
        public EditableStaticClassWrapper(IEditableStaticClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> @class)
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

        public override ICollection<TNestedDelegate> Delegates
        {
            get { return WrappedObject.Delegates; }
            set { WrappedObject.Delegates = value; }
        }

        public override TDocument Document
        {
            get { return WrappedObject.Document; }
            set { WrappedObject.Document = value; }
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

        public override TNamespace Namespace
        {
            get { return WrappedObject.Namespace; }
            set { WrappedObject.Namespace = value; }
        }

        public override TProject Project
        {
            get { return WrappedObject.Project; }
            set { WrappedObject.Project = value; }
        }

        public override TSolution Solution
        {
            get { return WrappedObject.Solution; }
            set { WrappedObject.Solution = value; }
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

        public override TypeVisibilityModifier Visibility
        {
            get { return WrappedObject.Visibility; }
            set { WrappedObject.Visibility = value; }
        }

        public IEditableStaticClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> WrappedObject { get; private set; }

        public override TPropertyCollection Properties => WrappedObject.Properties;
    }
}