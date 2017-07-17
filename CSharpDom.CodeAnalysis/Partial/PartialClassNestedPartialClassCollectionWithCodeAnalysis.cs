using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialClassNestedPartialClassCollectionWithCodeAnalysis :
        GenericPartialClassCollectionWithCodeAnalysis<
            PartialClassNestedPartialClassWithCodeAnalysis,
            PartialClassNestedAbstractPartialClassWithCodeAnalysis,
            PartialClassNestedSealedPartialClassWithCodeAnalysis,
            PartialClassNestedStaticPartialClassWithCodeAnalysis>
    {
        private PartialClassNestedPartialClassCollectionWithCodeAnalysis(
            IMemberList members,
            ICollection<PartialClassNestedAbstractPartialClassWithCodeAnalysis> abstractClasses,
            ICollection<PartialClassNestedPartialClassWithCodeAnalysis> classes,
            ICollection<PartialClassNestedSealedPartialClassWithCodeAnalysis> sealedClasses,
            ICollection<PartialClassNestedStaticPartialClassWithCodeAnalysis> staticClasses)
            : base(members, abstractClasses, classes, sealedClasses, staticClasses)
        {
        }

        internal static PartialClassNestedPartialClassCollectionWithCodeAnalysis Create(
            ClassNestedPartialClassCollectionWithCodeAnalysis classCollection)
        {
            var classes = new WrappedCollection<ClassNestedPartialClassWithCodeAnalysis, PartialClassNestedPartialClassWithCodeAnalysis>(
                classCollection.Classes,
                parent => new PartialClassNestedPartialClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.Classes = value);
            var abstractClasses = new WrappedCollection<ClassNestedAbstractPartialClassWithCodeAnalysis, PartialClassNestedAbstractPartialClassWithCodeAnalysis>(
                classCollection.AbstractClasses,
                parent => new PartialClassNestedAbstractPartialClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.AbstractClasses = value);
            var sealedClasses = new WrappedCollection<ClassNestedSealedPartialClassWithCodeAnalysis, PartialClassNestedSealedPartialClassWithCodeAnalysis>(
                classCollection.SealedClasses,
                parent => new PartialClassNestedSealedPartialClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.SealedClasses = value);
            var staticClasses = new WrappedCollection<ClassNestedStaticPartialClassWithCodeAnalysis, PartialClassNestedStaticPartialClassWithCodeAnalysis>(
                classCollection.StaticClasses,
                parent => new PartialClassNestedStaticPartialClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.StaticClasses = value);
            return new PartialClassNestedPartialClassCollectionWithCodeAnalysis(classCollection.Members, abstractClasses, classes, sealedClasses, staticClasses);
        }
    }
}
