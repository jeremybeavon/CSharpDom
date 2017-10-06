using CSharpDom.BaseClasses.Editable;
using CSharpDom.CodeAnalysis.Partial;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialStructNestedClassCollectionWithCodeAnalysis :
        EditableStructNestedClassCollection<
            PartialStructNestedClassWithCodeAnalysis,
            PartialStructNestedAbstractClassWithCodeAnalysis,
            PartialStructNestedSealedClassWithCodeAnalysis,
            PartialStructNestedStaticClassWithCodeAnalysis,
            PartialStructNestedPartialClassCollectionWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            StructNestedClassWithCodeAnalysis,
            PartialStructNestedClassWithCodeAnalysis> classes;
        private readonly WrappedCollection<
            StructNestedAbstractClassWithCodeAnalysis,
            PartialStructNestedAbstractClassWithCodeAnalysis> abstractClasses;
        private readonly WrappedCollection<
            StructNestedSealedClassWithCodeAnalysis,
            PartialStructNestedSealedClassWithCodeAnalysis> sealedClasses;
        private readonly WrappedCollection<
            StructNestedStaticClassWithCodeAnalysis,
            PartialStructNestedStaticClassWithCodeAnalysis> staticClasses;
        private readonly PartialStructNestedPartialClassCollectionWithCodeAnalysis partialClasses;

        public PartialStructNestedClassCollectionWithCodeAnalysis(
            StructNestedClassCollectionWithCodeAnalysis classCollection)
        {
            classes = new WrappedCollection<StructNestedClassWithCodeAnalysis, PartialStructNestedClassWithCodeAnalysis>(
                classCollection.Classes,
                parent => new PartialStructNestedClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.Classes = value);
            abstractClasses = new WrappedCollection<StructNestedAbstractClassWithCodeAnalysis, PartialStructNestedAbstractClassWithCodeAnalysis>(
                classCollection.AbstractClasses,
                parent => new PartialStructNestedAbstractClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.AbstractClasses = value);
            sealedClasses = new WrappedCollection<StructNestedSealedClassWithCodeAnalysis, PartialStructNestedSealedClassWithCodeAnalysis>(
                classCollection.SealedClasses,
                parent => new PartialStructNestedSealedClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.SealedClasses = value);
            staticClasses = new WrappedCollection<StructNestedStaticClassWithCodeAnalysis, PartialStructNestedStaticClassWithCodeAnalysis>(
                classCollection.StaticClasses,
                parent => new PartialStructNestedStaticClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.StaticClasses = value);
            partialClasses = PartialStructNestedPartialClassCollectionWithCodeAnalysis.Create(
                classCollection.PartialClasses);
        }

        public override ICollection<PartialStructNestedAbstractClassWithCodeAnalysis> AbstractClasses
        {
            get { return abstractClasses; }
            set { abstractClasses.Replace(value); }
        }

        public override PartialStructNestedPartialClassCollectionWithCodeAnalysis PartialClasses
        {
            get { return partialClasses; }
            set { partialClasses.Replace(value); }
        }

        public override ICollection<PartialStructNestedSealedClassWithCodeAnalysis> SealedClasses
        {
            get { return sealedClasses; }
            set { sealedClasses.Replace(value); }
        }

        public override ICollection<PartialStructNestedStaticClassWithCodeAnalysis> StaticClasses
        {
            get { return staticClasses; }
            set { staticClasses.Replace(value); }
        }

        public override ICollection<PartialStructNestedClassWithCodeAnalysis> Classes
        {
            get { return classes; }
            set { classes.Replace(value); }
        }
    }
}
