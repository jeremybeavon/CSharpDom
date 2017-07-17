using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class NestedStaticPartialClassNestedClassCollectionWithCodeAnalysis :
        EditableStaticClassNestedClassCollection<
            NestedStaticPartialClassNestedClassWithCodeAnalysis,
            NestedStaticPartialClassNestedAbstractClassWithCodeAnalysis,
            NestedStaticPartialClassNestedSealedClassWithCodeAnalysis,
            NestedStaticPartialClassNestedStaticClassWithCodeAnalysis,
            NestedStaticPartialClassNestedPartialClassCollectionWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            NestedStaticClassNestedClassWithCodeAnalysis,
            NestedStaticPartialClassNestedClassWithCodeAnalysis> classes;
        private readonly WrappedCollection<
            NestedStaticClassNestedAbstractClassWithCodeAnalysis,
            NestedStaticPartialClassNestedAbstractClassWithCodeAnalysis> abstractClasses;
        private readonly WrappedCollection<
            NestedStaticClassNestedSealedClassWithCodeAnalysis,
            NestedStaticPartialClassNestedSealedClassWithCodeAnalysis> sealedClasses;
        private readonly WrappedCollection<
            NestedStaticClassNestedStaticClassWithCodeAnalysis,
            NestedStaticPartialClassNestedStaticClassWithCodeAnalysis> staticClasses;
        private readonly NestedStaticPartialClassNestedPartialClassCollectionWithCodeAnalysis partialClasses;

        public NestedStaticPartialClassNestedClassCollectionWithCodeAnalysis(
            NestedStaticClassNestedClassCollectionWithCodeAnalysis classCollection)
        {
            classes = new WrappedCollection<NestedStaticClassNestedClassWithCodeAnalysis, NestedStaticPartialClassNestedClassWithCodeAnalysis>(
                classCollection.Classes,
                parent => new NestedStaticPartialClassNestedClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.Classes = value);
            abstractClasses = new WrappedCollection<NestedStaticClassNestedAbstractClassWithCodeAnalysis, NestedStaticPartialClassNestedAbstractClassWithCodeAnalysis>(
                classCollection.AbstractClasses,
                parent => new NestedStaticPartialClassNestedAbstractClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.AbstractClasses = value);
            sealedClasses = new WrappedCollection<NestedStaticClassNestedSealedClassWithCodeAnalysis, NestedStaticPartialClassNestedSealedClassWithCodeAnalysis>(
                classCollection.SealedClasses,
                parent => new NestedStaticPartialClassNestedSealedClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.SealedClasses = value);
            staticClasses = new WrappedCollection<NestedStaticClassNestedStaticClassWithCodeAnalysis, NestedStaticPartialClassNestedStaticClassWithCodeAnalysis>(
                classCollection.StaticClasses,
                parent => new NestedStaticPartialClassNestedStaticClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.StaticClasses = value);
            partialClasses = NestedStaticPartialClassNestedPartialClassCollectionWithCodeAnalysis.Create(
                classCollection.PartialClasses);
        }

        public override ICollection<NestedStaticPartialClassNestedAbstractClassWithCodeAnalysis> AbstractClasses
        {
            get { return abstractClasses; }
            set { abstractClasses.Replace(value); }
        }

        public override NestedStaticPartialClassNestedPartialClassCollectionWithCodeAnalysis PartialClasses
        {
            get { return partialClasses; }
            set { partialClasses.Replace(value); }
        }

        public override ICollection<NestedStaticPartialClassNestedSealedClassWithCodeAnalysis> SealedClasses
        {
            get { return sealedClasses; }
            set { sealedClasses.Replace(value); }
        }

        public override ICollection<NestedStaticPartialClassNestedStaticClassWithCodeAnalysis> StaticClasses
        {
            get { return staticClasses; }
            set { staticClasses.Replace(value); }
        }

        public override ICollection<NestedStaticPartialClassNestedClassWithCodeAnalysis> Classes
        {
            get { return classes; }
            set { classes.Replace(value); }
        }
    }
}
