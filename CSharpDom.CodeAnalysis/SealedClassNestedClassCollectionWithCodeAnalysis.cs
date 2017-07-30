using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SealedClassNestedClassCollectionWithCodeAnalysis :
        EditableClassNestedClassCollection<
            SealedClassNestedClassWithCodeAnalysis,
            SealedClassNestedAbstractClassWithCodeAnalysis,
            SealedClassNestedSealedClassWithCodeAnalysis,
            SealedClassNestedStaticClassWithCodeAnalysis,
            SealedClassNestedPartialClassCollectionWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            ClassNestedClassWithCodeAnalysis,
            SealedClassNestedClassWithCodeAnalysis> classes;
        private readonly WrappedCollection<
            ClassNestedAbstractClassWithCodeAnalysis,
            SealedClassNestedAbstractClassWithCodeAnalysis> abstractClasses;
        private readonly WrappedCollection<
            ClassNestedSealedClassWithCodeAnalysis,
            SealedClassNestedSealedClassWithCodeAnalysis> sealedClasses;
        private readonly WrappedCollection<
            ClassNestedStaticClassWithCodeAnalysis,
            SealedClassNestedStaticClassWithCodeAnalysis> staticClasses;
        private readonly SealedClassNestedPartialClassCollectionWithCodeAnalysis partialClasses;

        public SealedClassNestedClassCollectionWithCodeAnalysis(
            ClassNestedClassCollectionWithCodeAnalysis classCollection)
        {
            classes = new WrappedCollection<ClassNestedClassWithCodeAnalysis, SealedClassNestedClassWithCodeAnalysis>(
                classCollection.Classes,
                parent => new SealedClassNestedClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.Classes = value);
            abstractClasses = new WrappedCollection<ClassNestedAbstractClassWithCodeAnalysis, SealedClassNestedAbstractClassWithCodeAnalysis>(
                classCollection.AbstractClasses,
                parent => new SealedClassNestedAbstractClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.AbstractClasses = value);
            sealedClasses = new WrappedCollection<ClassNestedSealedClassWithCodeAnalysis, SealedClassNestedSealedClassWithCodeAnalysis>(
                classCollection.SealedClasses,
                parent => new SealedClassNestedSealedClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.SealedClasses = value);
            staticClasses = new WrappedCollection<ClassNestedStaticClassWithCodeAnalysis, SealedClassNestedStaticClassWithCodeAnalysis>(
                classCollection.StaticClasses,
                parent => new SealedClassNestedStaticClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.StaticClasses = value);
            partialClasses = SealedClassNestedPartialClassCollectionWithCodeAnalysis.Create(
                classCollection.PartialClasses);
        }

        public override ICollection<SealedClassNestedAbstractClassWithCodeAnalysis> AbstractClasses
        {
            get { return abstractClasses; }
            set { abstractClasses.Replace(value); }
        }

        public override SealedClassNestedPartialClassCollectionWithCodeAnalysis PartialClasses
        {
            get { return partialClasses; }
            set { partialClasses.Replace(value); }
        }

        public override ICollection<SealedClassNestedSealedClassWithCodeAnalysis> SealedClasses
        {
            get { return sealedClasses; }
            set { sealedClasses.Replace(value); }
        }

        public override ICollection<SealedClassNestedStaticClassWithCodeAnalysis> StaticClasses
        {
            get { return staticClasses; }
            set { staticClasses.Replace(value); }
        }

        public override ICollection<SealedClassNestedClassWithCodeAnalysis> Classes
        {
            get { return classes; }
            set { classes.Replace(value); }
        }
    }
}
