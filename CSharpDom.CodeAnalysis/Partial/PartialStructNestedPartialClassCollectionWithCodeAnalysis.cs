using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialStructNestedPartialClassCollectionWithCodeAnalysis :
        GenericPartialClassCollectionWithCodeAnalysis<
            PartialStructNestedPartialClassWithCodeAnalysis,
            PartialStructNestedAbstractPartialClassWithCodeAnalysis,
            PartialStructNestedSealedPartialClassWithCodeAnalysis,
            PartialStructNestedStaticPartialClassWithCodeAnalysis>
    {
        private PartialStructNestedPartialClassCollectionWithCodeAnalysis(
            IMemberList members,
            ICollection<PartialStructNestedAbstractPartialClassWithCodeAnalysis> abstractClasses,
            ICollection<PartialStructNestedPartialClassWithCodeAnalysis> classes,
            ICollection<PartialStructNestedSealedPartialClassWithCodeAnalysis> sealedClasses,
            ICollection<PartialStructNestedStaticPartialClassWithCodeAnalysis> staticClasses)
            : base(members, abstractClasses, classes, sealedClasses, staticClasses)
        {
        }

        internal static PartialStructNestedPartialClassCollectionWithCodeAnalysis Create(
            StructNestedPartialClassCollectionWithCodeAnalysis classCollection)
        {
            var classes = new WrappedCollection<StructNestedPartialClassWithCodeAnalysis, PartialStructNestedPartialClassWithCodeAnalysis>(
                classCollection.Classes,
                parent => new PartialStructNestedPartialClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.Classes = value);
            var abstractClasses = new WrappedCollection<StructNestedAbstractPartialClassWithCodeAnalysis, PartialStructNestedAbstractPartialClassWithCodeAnalysis>(
                classCollection.AbstractClasses,
                parent => new PartialStructNestedAbstractPartialClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.AbstractClasses = value);
            var sealedClasses = new WrappedCollection<StructNestedSealedPartialClassWithCodeAnalysis, PartialStructNestedSealedPartialClassWithCodeAnalysis>(
                classCollection.SealedClasses,
                parent => new PartialStructNestedSealedPartialClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.SealedClasses = value);
            var staticClasses = new WrappedCollection<StructNestedStaticPartialClassWithCodeAnalysis, PartialStructNestedStaticPartialClassWithCodeAnalysis>(
                classCollection.StaticClasses,
                parent => new PartialStructNestedStaticPartialClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.StaticClasses = value);
            return new PartialStructNestedPartialClassCollectionWithCodeAnalysis(classCollection.Members, abstractClasses, classes, sealedClasses, staticClasses);
        }
    }
}
