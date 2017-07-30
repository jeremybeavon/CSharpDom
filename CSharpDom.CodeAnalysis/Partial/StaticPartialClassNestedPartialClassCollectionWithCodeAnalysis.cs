using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StaticPartialClassNestedPartialClassCollectionWithCodeAnalysis :
        GenericPartialClassCollectionWithCodeAnalysis<
            StaticPartialClassNestedPartialClassWithCodeAnalysis,
            StaticPartialClassNestedAbstractPartialClassWithCodeAnalysis,
            StaticPartialClassNestedSealedPartialClassWithCodeAnalysis,
            StaticPartialClassNestedStaticPartialClassWithCodeAnalysis>
    {
        private StaticPartialClassNestedPartialClassCollectionWithCodeAnalysis(
            IMemberList members,
            ICollection<StaticPartialClassNestedAbstractPartialClassWithCodeAnalysis> abstractClasses,
            ICollection<StaticPartialClassNestedPartialClassWithCodeAnalysis> classes,
            ICollection<StaticPartialClassNestedSealedPartialClassWithCodeAnalysis> sealedClasses,
            ICollection<StaticPartialClassNestedStaticPartialClassWithCodeAnalysis> staticClasses)
            : base(members, abstractClasses, classes, sealedClasses, staticClasses)
        {
        }

        internal static StaticPartialClassNestedPartialClassCollectionWithCodeAnalysis Create(
            StaticClassNestedPartialClassCollectionWithCodeAnalysis classCollection)
        {
            var classes = new WrappedCollection<StaticClassNestedPartialClassWithCodeAnalysis, StaticPartialClassNestedPartialClassWithCodeAnalysis>(
                classCollection.Classes,
                parent => new StaticPartialClassNestedPartialClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.Classes = value);
            var abstractClasses = new WrappedCollection<StaticClassNestedAbstractPartialClassWithCodeAnalysis, StaticPartialClassNestedAbstractPartialClassWithCodeAnalysis>(
                classCollection.AbstractClasses,
                parent => new StaticPartialClassNestedAbstractPartialClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.AbstractClasses = value);
            var sealedClasses = new WrappedCollection<StaticClassNestedSealedPartialClassWithCodeAnalysis, StaticPartialClassNestedSealedPartialClassWithCodeAnalysis>(
                classCollection.SealedClasses,
                parent => new StaticPartialClassNestedSealedPartialClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.SealedClasses = value);
            var staticClasses = new WrappedCollection<StaticClassNestedStaticPartialClassWithCodeAnalysis, StaticPartialClassNestedStaticPartialClassWithCodeAnalysis>(
                classCollection.StaticClasses,
                parent => new StaticPartialClassNestedStaticPartialClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.StaticClasses = value);
            return new StaticPartialClassNestedPartialClassCollectionWithCodeAnalysis(classCollection.Members, abstractClasses, classes, sealedClasses, staticClasses);
        }
    }
}
