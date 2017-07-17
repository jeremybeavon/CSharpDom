using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class NestedStaticPartialClassNestedPartialClassCollectionWithCodeAnalysis :
        GenericPartialClassCollectionWithCodeAnalysis<
            NestedStaticPartialClassNestedPartialClassWithCodeAnalysis,
            NestedStaticPartialClassNestedAbstractPartialClassWithCodeAnalysis,
            NestedStaticPartialClassNestedSealedPartialClassWithCodeAnalysis,
            NestedStaticPartialClassNestedStaticPartialClassWithCodeAnalysis>
    {
        private NestedStaticPartialClassNestedPartialClassCollectionWithCodeAnalysis(
            IMemberList members,
            ICollection<NestedStaticPartialClassNestedAbstractPartialClassWithCodeAnalysis> abstractClasses,
            ICollection<NestedStaticPartialClassNestedPartialClassWithCodeAnalysis> classes,
            ICollection<NestedStaticPartialClassNestedSealedPartialClassWithCodeAnalysis> sealedClasses,
            ICollection<NestedStaticPartialClassNestedStaticPartialClassWithCodeAnalysis> staticClasses)
            : base(members, abstractClasses, classes, sealedClasses, staticClasses)
        {
        }

        internal static NestedStaticPartialClassNestedPartialClassCollectionWithCodeAnalysis Create(
            NestedStaticClassNestedPartialClassCollectionWithCodeAnalysis classCollection)
        {
            var classes = new WrappedCollection<NestedStaticClassNestedPartialClassWithCodeAnalysis, NestedStaticPartialClassNestedPartialClassWithCodeAnalysis>(
                classCollection.Classes,
                parent => new NestedStaticPartialClassNestedPartialClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.Classes = value);
            var abstractClasses = new WrappedCollection<NestedStaticClassNestedAbstractPartialClassWithCodeAnalysis, NestedStaticPartialClassNestedAbstractPartialClassWithCodeAnalysis>(
                classCollection.AbstractClasses,
                parent => new NestedStaticPartialClassNestedAbstractPartialClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.AbstractClasses = value);
            var sealedClasses = new WrappedCollection<NestedStaticClassNestedSealedPartialClassWithCodeAnalysis, NestedStaticPartialClassNestedSealedPartialClassWithCodeAnalysis>(
                classCollection.SealedClasses,
                parent => new NestedStaticPartialClassNestedSealedPartialClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.SealedClasses = value);
            var staticClasses = new WrappedCollection<NestedStaticClassNestedStaticPartialClassWithCodeAnalysis, NestedStaticPartialClassNestedStaticPartialClassWithCodeAnalysis>(
                classCollection.StaticClasses,
                parent => new NestedStaticPartialClassNestedStaticPartialClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.StaticClasses = value);
            return new NestedStaticPartialClassNestedPartialClassCollectionWithCodeAnalysis(classCollection.Members, abstractClasses, classes, sealedClasses, staticClasses);
        }
    }
}
