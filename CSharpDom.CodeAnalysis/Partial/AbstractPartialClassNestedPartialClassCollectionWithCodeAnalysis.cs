using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class AbstractPartialClassNestedPartialClassCollectionWithCodeAnalysis :
        GenericPartialClassCollectionWithCodeAnalysis<
            AbstractPartialClassNestedPartialClassWithCodeAnalysis,
            AbstractPartialClassNestedAbstractPartialClassWithCodeAnalysis,
            AbstractPartialClassNestedSealedPartialClassWithCodeAnalysis,
            AbstractPartialClassNestedStaticPartialClassWithCodeAnalysis>
    {
        private AbstractPartialClassNestedPartialClassCollectionWithCodeAnalysis(
            IMemberList members,
            ICollection<AbstractPartialClassNestedAbstractPartialClassWithCodeAnalysis> abstractClasses,
            ICollection<AbstractPartialClassNestedPartialClassWithCodeAnalysis> classes,
            ICollection<AbstractPartialClassNestedSealedPartialClassWithCodeAnalysis> sealedClasses,
            ICollection<AbstractPartialClassNestedStaticPartialClassWithCodeAnalysis> staticClasses)
            : base(members, abstractClasses, classes, sealedClasses, staticClasses)
        {
        }

        internal static AbstractPartialClassNestedPartialClassCollectionWithCodeAnalysis Create(
            ClassNestedPartialClassCollectionWithCodeAnalysis classCollection)
        {
            var classes = new WrappedCollection<ClassNestedPartialClassWithCodeAnalysis, AbstractPartialClassNestedPartialClassWithCodeAnalysis>(
                classCollection.Classes,
                parent => new AbstractPartialClassNestedPartialClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.Classes = value);
            var abstractClasses = new WrappedCollection<ClassNestedAbstractPartialClassWithCodeAnalysis, AbstractPartialClassNestedAbstractPartialClassWithCodeAnalysis>(
                classCollection.AbstractClasses,
                parent => new AbstractPartialClassNestedAbstractPartialClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.AbstractClasses = value);
            var sealedClasses = new WrappedCollection<ClassNestedSealedPartialClassWithCodeAnalysis, AbstractPartialClassNestedSealedPartialClassWithCodeAnalysis>(
                classCollection.SealedClasses,
                parent => new AbstractPartialClassNestedSealedPartialClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.SealedClasses = value);
            var staticClasses = new WrappedCollection<ClassNestedStaticPartialClassWithCodeAnalysis, AbstractPartialClassNestedStaticPartialClassWithCodeAnalysis>(
                classCollection.StaticClasses,
                parent => new AbstractPartialClassNestedStaticPartialClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.StaticClasses = value);
            return new AbstractPartialClassNestedPartialClassCollectionWithCodeAnalysis(classCollection.Members, abstractClasses, classes, sealedClasses, staticClasses);
        }
    }
}
