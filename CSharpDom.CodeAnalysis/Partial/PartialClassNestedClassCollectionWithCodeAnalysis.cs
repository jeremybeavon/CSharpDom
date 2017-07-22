using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialClassNestedClassCollectionWithCodeAnalysis :
        EditableClassNestedClassCollection<
            PartialClassNestedClassWithCodeAnalysis,
            PartialClassNestedAbstractClassWithCodeAnalysis,
            PartialClassNestedSealedClassWithCodeAnalysis,
            PartialClassNestedStaticClassWithCodeAnalysis,
            PartialClassNestedPartialClassCollectionWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            ClassNestedClassWithCodeAnalysis,
            PartialClassNestedClassWithCodeAnalysis> classes;
        private readonly WrappedCollection<
            ClassNestedAbstractClassWithCodeAnalysis,
            PartialClassNestedAbstractClassWithCodeAnalysis> abstractClasses;
        private readonly WrappedCollection<
            ClassNestedSealedClassWithCodeAnalysis,
            PartialClassNestedSealedClassWithCodeAnalysis> sealedClasses;
        private readonly WrappedCollection<
            ClassNestedStaticClassWithCodeAnalysis,
            PartialClassNestedStaticClassWithCodeAnalysis> staticClasses;
        private readonly PartialClassNestedPartialClassCollectionWithCodeAnalysis partialClasses;

        public PartialClassNestedClassCollectionWithCodeAnalysis(
            ClassNestedClassCollectionWithCodeAnalysis classCollection)
        {
            classes = new WrappedCollection<ClassNestedClassWithCodeAnalysis, PartialClassNestedClassWithCodeAnalysis>(
                classCollection.Classes,
                parent => new PartialClassNestedClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.Classes = value);
            abstractClasses = new WrappedCollection<ClassNestedAbstractClassWithCodeAnalysis, PartialClassNestedAbstractClassWithCodeAnalysis>(
                classCollection.AbstractClasses,
                parent => new PartialClassNestedAbstractClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.AbstractClasses = value);
            sealedClasses = new WrappedCollection<ClassNestedSealedClassWithCodeAnalysis, PartialClassNestedSealedClassWithCodeAnalysis>(
                classCollection.SealedClasses,
                parent => new PartialClassNestedSealedClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.SealedClasses = value);
            staticClasses = new WrappedCollection<ClassNestedStaticClassWithCodeAnalysis, PartialClassNestedStaticClassWithCodeAnalysis>(
                classCollection.StaticClasses,
                parent => new PartialClassNestedStaticClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.StaticClasses = value);
            partialClasses = PartialClassNestedPartialClassCollectionWithCodeAnalysis.Create(
                classCollection.PartialClasses);
        }

        public override ICollection<PartialClassNestedAbstractClassWithCodeAnalysis> AbstractClasses
        {
            get { return abstractClasses; }
            set { abstractClasses.Replace(value); }
        }

        public override PartialClassNestedPartialClassCollectionWithCodeAnalysis PartialClasses
        {
            get { return partialClasses; }
            set { partialClasses.Replace(value); }
        }

        public override ICollection<PartialClassNestedSealedClassWithCodeAnalysis> SealedClasses
        {
            get { return sealedClasses; }
            set { sealedClasses.Replace(value); }
        }

        public override ICollection<PartialClassNestedStaticClassWithCodeAnalysis> StaticClasses
        {
            get { return staticClasses; }
            set { staticClasses.Replace(value); }
        }

        public override ICollection<PartialClassNestedClassWithCodeAnalysis> Classes
        {
            get { return classes; }
            set { classes.Replace(value); }
        }
    }
}
