using CSharpDom.Common;
using CSharpDom.Common.Editable;
using CSharpDom.Common.Editable.Partial;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableNestedClassCollectionWrapper<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> :
        EditableNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>,
        IWrapper<IEditableNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>>
        where TClass : IEditableNestedClass
        where TAbstractClass : IEditableNestedAbstractClass
        where TSealedClass : IEditableNestedSealedClass
        where TStaticClass : IEditableNestedStaticClass
        where TPartialClassCollection : IEditablePartialClassCollection
    {
        public EditableNestedClassCollectionWrapper(IEditableNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> collection)
        {
            WrappedObject = collection;
        }

        public override ICollection<TAbstractClass> AbstractClasses
        {
            get { return WrappedObject.AbstractClasses; }
            set { WrappedObject.AbstractClasses = value; }
        }

        public override TPartialClassCollection PartialClasses
        {
            get { return WrappedObject.PartialClasses; }
            set { WrappedObject.PartialClasses = value; }
        }

        public override ICollection<TSealedClass> SealedClasses
        {
            get { return WrappedObject.SealedClasses; }
            set { WrappedObject.SealedClasses = value; }
        }

        public override ICollection<TStaticClass> StaticClasses
        {
            get { return WrappedObject.StaticClasses; }
            set { WrappedObject.StaticClasses = value; }
        }

        protected override ICollection<TClass> Classes
        {
            get { return WrappedObject; }
            set { WrappedObject.Classes = value; }
        }

        public IEditableNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> WrappedObject { get; private set; }
    }
}