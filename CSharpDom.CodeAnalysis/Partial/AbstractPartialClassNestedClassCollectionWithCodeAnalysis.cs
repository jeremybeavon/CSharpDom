using CSharpDom.Editable;
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
            ClassNestedClassWithCodeAnalysis,
            AbstractPartialClassNestedClassWithCodeAnalysis> classes;
        private readonly WrappedCollection<
            ClassNestedAbstractClassWithCodeAnalysis,
            AbstractPartialClassNestedAbstractClassWithCodeAnalysis> abstractClasses;
        private readonly WrappedCollection<
            ClassNestedSealedClassWithCodeAnalysis,
            AbstractPartialClassNestedSealedClassWithCodeAnalysis> sealedClasses;
        private readonly WrappedCollection<
            ClassNestedStaticClassWithCodeAnalysis,
            AbstractPartialClassNestedStaticClassWithCodeAnalysis> staticClasses;
        private readonly AbstractPartialClassNestedPartialClassCollectionWithCodeAnalysis partialClasses;

        public AbstractPartialClassNestedClassCollectionWithCodeAnalysis(
            ClassNestedClassCollectionWithCodeAnalysis classCollection)
        {
            classes = new WrappedCollection<ClassNestedClassWithCodeAnalysis, AbstractPartialClassNestedClassWithCodeAnalysis>(
                classCollection.Classes,
                parent => new AbstractPartialClassNestedClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.Classes = value);
            abstractClasses = new WrappedCollection<ClassNestedAbstractClassWithCodeAnalysis, AbstractPartialClassNestedAbstractClassWithCodeAnalysis>(
                classCollection.AbstractClasses,
                parent => new AbstractPartialClassNestedAbstractClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.AbstractClasses = value);
            sealedClasses = new WrappedCollection<ClassNestedSealedClassWithCodeAnalysis, AbstractPartialClassNestedSealedClassWithCodeAnalysis>(
                classCollection.SealedClasses,
                parent => new AbstractPartialClassNestedSealedClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.SealedClasses = value);
            staticClasses = new WrappedCollection<ClassNestedStaticClassWithCodeAnalysis, AbstractPartialClassNestedStaticClassWithCodeAnalysis>(
                classCollection.StaticClasses,
                parent => new AbstractPartialClassNestedStaticClassWithCodeAnalysis(parent),
                child => child.InternalClass,
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
