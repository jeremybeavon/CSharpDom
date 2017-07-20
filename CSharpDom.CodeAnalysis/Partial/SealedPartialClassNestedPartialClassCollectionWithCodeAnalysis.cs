using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class SealedPartialClassNestedPartialClassCollectionWithCodeAnalysis :
        GenericPartialClassCollectionWithCodeAnalysis<
            SealedPartialClassNestedPartialClassWithCodeAnalysis,
            SealedPartialClassNestedAbstractPartialClassWithCodeAnalysis,
            SealedPartialClassNestedSealedPartialClassWithCodeAnalysis,
            SealedPartialClassNestedStaticPartialClassWithCodeAnalysis>
    {
        private SealedPartialClassNestedPartialClassCollectionWithCodeAnalysis(
            IMemberList members,
            ICollection<SealedPartialClassNestedAbstractPartialClassWithCodeAnalysis> abstractClasses,
            ICollection<SealedPartialClassNestedPartialClassWithCodeAnalysis> classes,
            ICollection<SealedPartialClassNestedSealedPartialClassWithCodeAnalysis> sealedClasses,
            ICollection<SealedPartialClassNestedStaticPartialClassWithCodeAnalysis> staticClasses)
            : base(members, abstractClasses, classes, sealedClasses, staticClasses)
        {
        }

        internal static SealedPartialClassNestedPartialClassCollectionWithCodeAnalysis Create(
            ClassNestedPartialClassCollectionWithCodeAnalysis classCollection)
        {
            var classes = new WrappedCollection<ClassNestedPartialClassWithCodeAnalysis, SealedPartialClassNestedPartialClassWithCodeAnalysis>(
                classCollection.Classes,
                parent => new SealedPartialClassNestedPartialClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.Classes = value);
            var abstractClasses = new WrappedCollection<ClassNestedAbstractPartialClassWithCodeAnalysis, SealedPartialClassNestedAbstractPartialClassWithCodeAnalysis>(
                classCollection.AbstractClasses,
                parent => new SealedPartialClassNestedAbstractPartialClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.AbstractClasses = value);
            var sealedClasses = new WrappedCollection<ClassNestedSealedPartialClassWithCodeAnalysis, SealedPartialClassNestedSealedPartialClassWithCodeAnalysis>(
                classCollection.SealedClasses,
                parent => new SealedPartialClassNestedSealedPartialClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.SealedClasses = value);
            var staticClasses = new WrappedCollection<ClassNestedStaticPartialClassWithCodeAnalysis, SealedPartialClassNestedStaticPartialClassWithCodeAnalysis>(
                classCollection.StaticClasses,
                parent => new SealedPartialClassNestedStaticPartialClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.StaticClasses = value);
            return new SealedPartialClassNestedPartialClassCollectionWithCodeAnalysis(classCollection.Members, abstractClasses, classes, sealedClasses, staticClasses);
        }
    }
}
