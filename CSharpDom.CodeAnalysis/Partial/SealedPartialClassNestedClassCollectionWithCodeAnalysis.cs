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
            ClassNestedClassWithCodeAnalysis,
            SealedPartialClassNestedClassWithCodeAnalysis> classes;
        private readonly WrappedCollection<
            ClassNestedAbstractClassWithCodeAnalysis,
            SealedPartialClassNestedAbstractClassWithCodeAnalysis> abstractClasses;
        private readonly WrappedCollection<
            ClassNestedSealedClassWithCodeAnalysis,
            SealedPartialClassNestedSealedClassWithCodeAnalysis> sealedClasses;
        private readonly WrappedCollection<
            ClassNestedStaticClassWithCodeAnalysis,
            SealedPartialClassNestedStaticClassWithCodeAnalysis> staticClasses;
        private readonly SealedPartialClassNestedPartialClassCollectionWithCodeAnalysis partialClasses;

        public SealedPartialClassNestedClassCollectionWithCodeAnalysis(
            ClassNestedClassCollectionWithCodeAnalysis classCollection)
        {
            classes = new WrappedCollection<ClassNestedClassWithCodeAnalysis, SealedPartialClassNestedClassWithCodeAnalysis>(
                classCollection.Classes,
                parent => new SealedPartialClassNestedClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.Classes = value);
            abstractClasses = new WrappedCollection<ClassNestedAbstractClassWithCodeAnalysis, SealedPartialClassNestedAbstractClassWithCodeAnalysis>(
                classCollection.AbstractClasses,
                parent => new SealedPartialClassNestedAbstractClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.AbstractClasses = value);
            sealedClasses = new WrappedCollection<ClassNestedSealedClassWithCodeAnalysis, SealedPartialClassNestedSealedClassWithCodeAnalysis>(
                classCollection.SealedClasses,
                parent => new SealedPartialClassNestedSealedClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.SealedClasses = value);
            staticClasses = new WrappedCollection<ClassNestedStaticClassWithCodeAnalysis, SealedPartialClassNestedStaticClassWithCodeAnalysis>(
                classCollection.StaticClasses,
                parent => new SealedPartialClassNestedStaticClassWithCodeAnalysis(parent),
                child => child.InternalClass,
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
