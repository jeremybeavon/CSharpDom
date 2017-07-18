using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class AbstractClassNestedPartialClassCollectionWithCodeAnalysis :
        GenericPartialClassCollectionWithCodeAnalysis<
            AbstractClassNestedPartialClassWithCodeAnalysis,
            AbstractClassNestedAbstractPartialClassWithCodeAnalysis,
            AbstractClassNestedSealedPartialClassWithCodeAnalysis,
            AbstractClassNestedStaticPartialClassWithCodeAnalysis>
    {
        private AbstractClassNestedPartialClassCollectionWithCodeAnalysis(
            IMemberList members,
            ICollection<AbstractClassNestedAbstractPartialClassWithCodeAnalysis> abstractClasses,
            ICollection<AbstractClassNestedPartialClassWithCodeAnalysis> classes,
            ICollection<AbstractClassNestedSealedPartialClassWithCodeAnalysis> sealedClasses,
            ICollection<AbstractClassNestedStaticPartialClassWithCodeAnalysis> staticClasses)
            : base(members, abstractClasses, classes, sealedClasses, staticClasses)
        {
        }

        internal static AbstractClassNestedPartialClassCollectionWithCodeAnalysis Create(
            ClassNestedPartialClassCollectionWithCodeAnalysis classCollection)
        {
            var classes = new WrappedCollection<ClassNestedPartialClassWithCodeAnalysis, AbstractClassNestedPartialClassWithCodeAnalysis>(
                classCollection.Classes,
                parent => new AbstractClassNestedPartialClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.Classes = value);
            var abstractClasses = new WrappedCollection<ClassNestedAbstractPartialClassWithCodeAnalysis, AbstractClassNestedAbstractPartialClassWithCodeAnalysis>(
                classCollection.AbstractClasses,
                parent => new AbstractClassNestedAbstractPartialClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.AbstractClasses = value);
            var sealedClasses = new WrappedCollection<ClassNestedSealedPartialClassWithCodeAnalysis, AbstractClassNestedSealedPartialClassWithCodeAnalysis>(
                classCollection.SealedClasses,
                parent => new AbstractClassNestedSealedPartialClassWithCodeAnalysis(parent),
                child => child.InternalClass,
                value => classCollection.SealedClasses = value);
            var staticClasses = new WrappedCollection<ClassNestedStaticPartialClassWithCodeAnalysis, AbstractClassNestedStaticPartialClassWithCodeAnalysis>(
                classCollection.StaticClasses,
                parent => new AbstractClassNestedStaticPartialClassWithCodeAnalysis(parent),
                child => child.Class,
                value => classCollection.StaticClasses = value);
            return new AbstractClassNestedPartialClassCollectionWithCodeAnalysis(classCollection.Members, abstractClasses, classes, sealedClasses, staticClasses);
        }
    }
}
