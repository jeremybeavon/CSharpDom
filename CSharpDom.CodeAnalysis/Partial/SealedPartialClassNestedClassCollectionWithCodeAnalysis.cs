using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class SealedPartialClassNestedClassCollectionWithCodeAnalysis :
        EditableClassNestedClassCollection<
            SealedPartialClassNestedClassWithCodeAnalysis,
            SealedPartialClassNestedAbstractClassWithCodeAnalysis,
            SealedPartialClassNestedSealedClassWithCodeAnalysis,
            SealedPartialClassNestedStaticClassWithCodeAnalysis,
            SealedPartialClassNestedPartialClassCollectionWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            SealedClassNestedClassWithCodeAnalysis,
            SealedPartialClassNestedClassWithCodeAnalysis> classes;
        private readonly WrappedCollection<
            SealedClassNestedAbstractClassWithCodeAnalysis,
            SealedPartialClassNestedAbstractClassWithCodeAnalysis> abstractClasses;
        private readonly WrappedCollection<
            SealedClassNestedSealedClassWithCodeAnalysis,
            SealedPartialClassNestedSealedClassWithCodeAnalysis> sealedClasses;
        private readonly WrappedCollection<
            SealedClassNestedStaticClassWithCodeAnalysis,
            SealedPartialClassNestedStaticClassWithCodeAnalysis> staticClasses;
        private readonly SealedPartialClassNestedPartialClassCollectionWithCodeAnalysis partialClasses;

        public SealedPartialClassNestedClassCollectionWithCodeAnalysis(
            SealedClassNestedClassCollectionWithCodeAnalysis classCollection)
        {
            classes = new WrappedCollection<SealedClassNestedClassWithCodeAnalysis, SealedPartialClassNestedClassWithCodeAnalysis>(
                classCollection.Classes,
                parent => new SealedPartialClassNestedClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.Classes = value);
            abstractClasses = new WrappedCollection<SealedClassNestedAbstractClassWithCodeAnalysis, SealedPartialClassNestedAbstractClassWithCodeAnalysis>(
                classCollection.AbstractClasses,
                parent => new SealedPartialClassNestedAbstractClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.AbstractClasses = value);
            sealedClasses = new WrappedCollection<SealedClassNestedSealedClassWithCodeAnalysis, SealedPartialClassNestedSealedClassWithCodeAnalysis>(
                classCollection.SealedClasses,
                parent => new SealedPartialClassNestedSealedClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.SealedClasses = value);
            staticClasses = new WrappedCollection<SealedClassNestedStaticClassWithCodeAnalysis, SealedPartialClassNestedStaticClassWithCodeAnalysis>(
                classCollection.StaticClasses,
                parent => new SealedPartialClassNestedStaticClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.StaticClasses = value);
            partialClasses = SealedPartialClassNestedPartialClassCollectionWithCodeAnalysis.Create(
                classCollection.PartialClasses);
        }

        public override ICollection<SealedPartialClassNestedAbstractClassWithCodeAnalysis> AbstractClasses
        {
            get { return abstractClasses; }
            set { abstractClasses.Replace(value); }
        }

        public override SealedPartialClassNestedPartialClassCollectionWithCodeAnalysis PartialClasses
        {
            get { return partialClasses; }
            set { partialClasses.Replace(value); }
        }

        public override ICollection<SealedPartialClassNestedSealedClassWithCodeAnalysis> SealedClasses
        {
            get { return sealedClasses; }
            set { sealedClasses.Replace(value); }
        }

        public override ICollection<SealedPartialClassNestedStaticClassWithCodeAnalysis> StaticClasses
        {
            get { return staticClasses; }
            set { staticClasses.Replace(value); }
        }

        public override ICollection<SealedPartialClassNestedClassWithCodeAnalysis> Classes
        {
            get { return classes; }
            set { classes.Replace(value); }
        }
    }
}
