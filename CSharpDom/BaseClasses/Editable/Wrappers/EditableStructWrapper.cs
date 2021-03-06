using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableStructWrapper<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> :
        EditableStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>,
        IWrapper<IEditableStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>>
        where TNamespace : IEditableNamespace
        where TDocument : IEditableDocument
        where TProject : IEditableProject
        where TSolution : IEditableSolution
        where TAttributeGroup : IEditableAttributeGroup
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TInterfaceReference : IEditableInterfaceReference
        where TEventCollection : IEditableStructEventCollection
        where TPropertyCollection : IEditableStructPropertyCollection
        where TIndexerCollection : IEditableStructIndexerCollection
        where TMethodCollection : IEditableStructMethodCollection
        where TFieldCollection : IEditableStructFieldCollection
        where TConstructor : IEditableStructConstructor
        where TOperatorOverload : IEditableOperatorOverload
        where TConversionOperator : IEditableConversionOperator
        where TNestedClassCollection : IEditableStructNestedClassCollection
        where TNestedDelegate : IEditableStructNestedDelegate
        where TNestedEnum : IEditableStructNestedEnum
        where TNestedInterface : IEditableStructNestedInterface
        where TNestedStructCollection : IEditableStructNestedStructCollection
        where TStaticConstructor : IEditableStaticConstructor
    {
        public EditableStructWrapper(IEditableStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> @struct)
        {
            WrappedObject = @struct;
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

        public override ICollection<TConstructor> Constructors
        {
            get { return WrappedObject.Constructors; }
            set { WrappedObject.Constructors = value; }
        }

        public override ICollection<TConversionOperator> ConversionOperators
        {
            get { return WrappedObject.ConversionOperators; }
            set { WrappedObject.ConversionOperators = value; }
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

        public override ICollection<TInterfaceReference> ImplementedInterfaces
        {
            get { return WrappedObject.ImplementedInterfaces; }
            set { WrappedObject.ImplementedInterfaces = value; }
        }

        public override TIndexerCollection Indexers
        {
            get { return WrappedObject.Indexers; }
            set { WrappedObject.Indexers = value; }
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

        public override ICollection<TOperatorOverload> OperatorOverloads
        {
            get { return WrappedObject.OperatorOverloads; }
            set { WrappedObject.OperatorOverloads = value; }
        }

        public override TProject Project
        {
            get { return WrappedObject.Project; }
            set { WrappedObject.Project = value; }
        }

        public override TPropertyCollection Properties
        {
            get { return WrappedObject.Properties; }
            set { WrappedObject.Properties = value; }
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

        public IEditableStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> WrappedObject { get; private set; }
    }
}