using CSharpDom.BaseClasses.Editable;
using CSharpDom.CodeAnalysis.Partial;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StaticPartialClassNestedClassCollectionWithCodeAnalysis :
        EditableStaticClassNestedClassCollection<
            StaticPartialClassNestedClassWithCodeAnalysis,
            StaticPartialClassNestedAbstractClassWithCodeAnalysis,
            StaticPartialClassNestedSealedClassWithCodeAnalysis,
            StaticPartialClassNestedStaticClassWithCodeAnalysis,
            StaticPartialClassNestedPartialClassCollectionWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            StaticClassNestedClassWithCodeAnalysis,
            StaticPartialClassNestedClassWithCodeAnalysis> classes;
        private readonly WrappedCollection<
            StaticClassNestedAbstractClassWithCodeAnalysis,
            StaticPartialClassNestedAbstractClassWithCodeAnalysis> abstractClasses;
        private readonly WrappedCollection<
            StaticClassNestedSealedClassWithCodeAnalysis,
            StaticPartialClassNestedSealedClassWithCodeAnalysis> sealedClasses;
        private readonly WrappedCollection<
            StaticClassNestedStaticClassWithCodeAnalysis,
            StaticPartialClassNestedStaticClassWithCodeAnalysis> staticClasses;
        private readonly StaticPartialClassNestedPartialClassCollectionWithCodeAnalysis partialClasses;

        internal StaticPartialClassNestedClassCollectionWithCodeAnalysis(
            StaticClassNestedClassCollectionWithCodeAnalysis classCollection)
        {
            classes = new WrappedCollection<StaticClassNestedClassWithCodeAnalysis, StaticPartialClassNestedClassWithCodeAnalysis>(
                classCollection.Classes,
                parent => new StaticPartialClassNestedClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.Classes = value);
            abstractClasses = new WrappedCollection<StaticClassNestedAbstractClassWithCodeAnalysis, StaticPartialClassNestedAbstractClassWithCodeAnalysis>(
                classCollection.AbstractClasses,
                parent => new StaticPartialClassNestedAbstractClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.AbstractClasses = value);
            sealedClasses = new WrappedCollection<StaticClassNestedSealedClassWithCodeAnalysis, StaticPartialClassNestedSealedClassWithCodeAnalysis>(
                classCollection.SealedClasses,
                parent => new StaticPartialClassNestedSealedClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.SealedClasses = value);
            staticClasses = new WrappedCollection<StaticClassNestedStaticClassWithCodeAnalysis, StaticPartialClassNestedStaticClassWithCodeAnalysis>(
                classCollection.StaticClasses,
                parent => new StaticPartialClassNestedStaticClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.StaticClasses = value);
            partialClasses = StaticPartialClassNestedPartialClassCollectionWithCodeAnalysis.Create(classCollection.PartialClasses);
        }

        public override ICollection<StaticPartialClassNestedAbstractClassWithCodeAnalysis> AbstractClasses
        {
            get { return abstractClasses; }
            set { abstractClasses.Replace(value); }
        }

        public override ICollection<StaticPartialClassNestedClassWithCodeAnalysis> Classes
        {
            get { return classes; }
            set { classes.Replace(value); }
        }

        public override ICollection<StaticPartialClassNestedSealedClassWithCodeAnalysis> SealedClasses
        {
            get { return sealedClasses; }
            set { sealedClasses.Replace(value); }
        }

        public override ICollection<StaticPartialClassNestedStaticClassWithCodeAnalysis> StaticClasses
        {
            get { return staticClasses; }
            set { staticClasses.Replace(value); }
        }

        public override StaticPartialClassNestedPartialClassCollectionWithCodeAnalysis PartialClasses
        {
            get { return partialClasses; }
            set { partialClasses.Replace(value); }
        }
    }
}
