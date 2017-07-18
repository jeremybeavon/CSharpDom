using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class SealedClassNestedPartialClassCollectionWithCodeAnalysis :
        GenericPartialClassCollectionWithCodeAnalysis<
            SealedClassNestedPartialClassWithCodeAnalysis,
            SealedClassNestedAbstractPartialClassWithCodeAnalysis,
            SealedClassNestedSealedPartialClassWithCodeAnalysis,
            SealedClassNestedStaticPartialClassWithCodeAnalysis>
    {
        private SealedClassNestedPartialClassCollectionWithCodeAnalysis(
            IMemberList members,
            ICollection<SealedClassNestedAbstractPartialClassWithCodeAnalysis> abstractClasses,
            ICollection<SealedClassNestedPartialClassWithCodeAnalysis> classes,
            ICollection<SealedClassNestedSealedPartialClassWithCodeAnalysis> sealedClasses,
            ICollection<SealedClassNestedStaticPartialClassWithCodeAnalysis> staticClasses)
            : base(members, abstractClasses, classes, sealedClasses, staticClasses)
        {
        }

        internal static SealedClassNestedPartialClassCollectionWithCodeAnalysis Create(
            ClassNestedPartialClassCollectionWithCodeAnalysis classCollection)
        {
            var classes = new WrappedCollection<ClassNestedPartialClassWithCodeAnalysis, SealedClassNestedPartialClassWithCodeAnalysis>(
                classCollection.Classes,
                parent => new SealedClassNestedPartialClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.Classes = value);
            var abstractClasses = new WrappedCollection<ClassNestedAbstractPartialClassWithCodeAnalysis, SealedClassNestedAbstractPartialClassWithCodeAnalysis>(
                classCollection.AbstractClasses,
                parent => new SealedClassNestedAbstractPartialClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.AbstractClasses = value);
            var sealedClasses = new WrappedCollection<ClassNestedSealedPartialClassWithCodeAnalysis, SealedClassNestedSealedPartialClassWithCodeAnalysis>(
                classCollection.SealedClasses,
                parent => new SealedClassNestedSealedPartialClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.SealedClasses = value);
            var staticClasses = new WrappedCollection<ClassNestedStaticPartialClassWithCodeAnalysis, SealedClassNestedStaticPartialClassWithCodeAnalysis>(
                classCollection.StaticClasses,
                parent => new SealedClassNestedStaticPartialClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.StaticClasses = value);
            return new SealedClassNestedPartialClassCollectionWithCodeAnalysis(classCollection.Members, abstractClasses, classes, sealedClasses, staticClasses);
        }
    }
}
