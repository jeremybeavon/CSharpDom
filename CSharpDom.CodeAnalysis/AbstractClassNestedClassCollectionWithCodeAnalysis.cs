using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractClassNestedClassCollectionWithCodeAnalysis :
        EditableClassNestedClassCollection<
            AbstractClassNestedClassWithCodeAnalysis,
            AbstractClassNestedAbstractClassWithCodeAnalysis,
            AbstractClassNestedSealedClassWithCodeAnalysis,
            AbstractClassNestedStaticClassWithCodeAnalysis,
            AbstractClassNestedPartialClassCollectionWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            ClassNestedClassWithCodeAnalysis,
            AbstractClassNestedClassWithCodeAnalysis> classes;
        private readonly WrappedCollection<
            ClassNestedAbstractClassWithCodeAnalysis,
            AbstractClassNestedAbstractClassWithCodeAnalysis> abstractClasses;
        private readonly WrappedCollection<
            ClassNestedSealedClassWithCodeAnalysis,
            AbstractClassNestedSealedClassWithCodeAnalysis> sealedClasses;
        private readonly WrappedCollection<
            ClassNestedStaticClassWithCodeAnalysis,
            AbstractClassNestedStaticClassWithCodeAnalysis> staticClasses;
        private readonly AbstractClassNestedPartialClassCollectionWithCodeAnalysis partialClasses;

        public AbstractClassNestedClassCollectionWithCodeAnalysis(
            ClassNestedClassCollectionWithCodeAnalysis classCollection)
        {
            classes = new WrappedCollection<ClassNestedClassWithCodeAnalysis, AbstractClassNestedClassWithCodeAnalysis>(
                classCollection.Classes,
                parent => new AbstractClassNestedClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.Classes = value);
            abstractClasses = new WrappedCollection<ClassNestedAbstractClassWithCodeAnalysis, AbstractClassNestedAbstractClassWithCodeAnalysis>(
                classCollection.AbstractClasses,
                parent => new AbstractClassNestedAbstractClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.AbstractClasses = value);
            sealedClasses = new WrappedCollection<ClassNestedSealedClassWithCodeAnalysis, AbstractClassNestedSealedClassWithCodeAnalysis>(
                classCollection.SealedClasses,
                parent => new AbstractClassNestedSealedClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.SealedClasses = value);
            staticClasses = new WrappedCollection<ClassNestedStaticClassWithCodeAnalysis, AbstractClassNestedStaticClassWithCodeAnalysis>(
                classCollection.StaticClasses,
                parent => new AbstractClassNestedStaticClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.StaticClasses = value);
            partialClasses = AbstractClassNestedPartialClassCollectionWithCodeAnalysis.Create(
                classCollection.PartialClasses);
        }

        public override ICollection<AbstractClassNestedAbstractClassWithCodeAnalysis> AbstractClasses
        {
            get { return abstractClasses; }
            set { abstractClasses.Replace(value); }
        }

        public override AbstractClassNestedPartialClassCollectionWithCodeAnalysis PartialClasses
        {
            get { return partialClasses; }
            set { partialClasses.Replace(value); }
        }

        public override ICollection<AbstractClassNestedSealedClassWithCodeAnalysis> SealedClasses
        {
            get { return sealedClasses; }
            set { sealedClasses.Replace(value); }
        }

        public override ICollection<AbstractClassNestedStaticClassWithCodeAnalysis> StaticClasses
        {
            get { return staticClasses; }
            set { staticClasses.Replace(value); }
        }

        public override ICollection<AbstractClassNestedClassWithCodeAnalysis> Classes
        {
            get { return classes; }
            set { classes.Replace(value); }
        }
    }
}
