using CSharpDom.BaseClasses.Editable;
using CSharpDom.CodeAnalysis.Partial;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class AbstractPartialClassNestedClassCollectionWithCodeAnalysis :
        EditableClassNestedClassCollection<
            AbstractPartialClassNestedClassWithCodeAnalysis,
            AbstractPartialClassNestedAbstractClassWithCodeAnalysis,
            AbstractPartialClassNestedSealedClassWithCodeAnalysis,
            AbstractPartialClassNestedStaticClassWithCodeAnalysis,
            AbstractPartialClassNestedPartialClassCollectionWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            AbstractClassNestedClassWithCodeAnalysis,
            AbstractPartialClassNestedClassWithCodeAnalysis> classes;
        private readonly WrappedCollection<
            AbstractClassNestedAbstractClassWithCodeAnalysis,
            AbstractPartialClassNestedAbstractClassWithCodeAnalysis> abstractClasses;
        private readonly WrappedCollection<
            AbstractClassNestedSealedClassWithCodeAnalysis,
            AbstractPartialClassNestedSealedClassWithCodeAnalysis> sealedClasses;
        private readonly WrappedCollection<
            AbstractClassNestedStaticClassWithCodeAnalysis,
            AbstractPartialClassNestedStaticClassWithCodeAnalysis> staticClasses;
        private readonly AbstractPartialClassNestedPartialClassCollectionWithCodeAnalysis partialClasses;

        public AbstractPartialClassNestedClassCollectionWithCodeAnalysis(
            AbstractClassNestedClassCollectionWithCodeAnalysis classCollection)
        {
            classes = new WrappedCollection<AbstractClassNestedClassWithCodeAnalysis, AbstractPartialClassNestedClassWithCodeAnalysis>(
                classCollection.Classes,
                parent => new AbstractPartialClassNestedClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.Classes = value);
            abstractClasses = new WrappedCollection<AbstractClassNestedAbstractClassWithCodeAnalysis, AbstractPartialClassNestedAbstractClassWithCodeAnalysis>(
                classCollection.AbstractClasses,
                parent => new AbstractPartialClassNestedAbstractClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.AbstractClasses = value);
            sealedClasses = new WrappedCollection<AbstractClassNestedSealedClassWithCodeAnalysis, AbstractPartialClassNestedSealedClassWithCodeAnalysis>(
                classCollection.SealedClasses,
                parent => new AbstractPartialClassNestedSealedClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.SealedClasses = value);
            staticClasses = new WrappedCollection<AbstractClassNestedStaticClassWithCodeAnalysis, AbstractPartialClassNestedStaticClassWithCodeAnalysis>(
                classCollection.StaticClasses,
                parent => new AbstractPartialClassNestedStaticClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.StaticClasses = value);
            partialClasses = AbstractPartialClassNestedPartialClassCollectionWithCodeAnalysis.Create(
                classCollection.PartialClasses);
        }

        public override ICollection<AbstractPartialClassNestedAbstractClassWithCodeAnalysis> AbstractClasses
        {
            get { return abstractClasses; }
            set { abstractClasses.Replace(value); }
        }

        public override AbstractPartialClassNestedPartialClassCollectionWithCodeAnalysis PartialClasses
        {
            get { return partialClasses; }
            set { partialClasses.Replace(value); }
        }

        public override ICollection<AbstractPartialClassNestedSealedClassWithCodeAnalysis> SealedClasses
        {
            get { return sealedClasses; }
            set { sealedClasses.Replace(value); }
        }

        public override ICollection<AbstractPartialClassNestedStaticClassWithCodeAnalysis> StaticClasses
        {
            get { return staticClasses; }
            set { staticClasses.Replace(value); }
        }

        public override ICollection<AbstractPartialClassNestedClassWithCodeAnalysis> Classes
        {
            get { return classes; }
            set { classes.Replace(value); }
        }
    }
}
