using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StaticClassNestedPartialClassCollectionWithCodeAnalysis :
        GenericPartialClassCollectionWithCodeAnalysis<
            StaticClassNestedPartialClassWithCodeAnalysis,
            StaticClassNestedAbstractPartialClassWithCodeAnalysis,
            StaticClassNestedSealedPartialClassWithCodeAnalysis,
            StaticClassNestedStaticPartialClassWithCodeAnalysis>
    {
        private StaticClassNestedPartialClassCollectionWithCodeAnalysis(
            IMemberList members,
            ICollection<StaticClassNestedAbstractPartialClassWithCodeAnalysis> abstractClasses,
            ICollection<StaticClassNestedPartialClassWithCodeAnalysis> classes,
            ICollection<StaticClassNestedSealedPartialClassWithCodeAnalysis> sealedClasses,
            ICollection<StaticClassNestedStaticPartialClassWithCodeAnalysis> staticClasses)
            : base(members, abstractClasses, classes, sealedClasses, staticClasses)
        {
        }

        internal static StaticClassNestedPartialClassCollectionWithCodeAnalysis Create<TStaticClass>(
            InternalStaticTypeWithCodeAnalysis<TStaticClass> classType)
            where TStaticClass : class, IHasSyntax<ClassDeclarationSyntax>
        {
            var classes = new StaticTypeMemberListWrapper<TStaticClass, StaticClassNestedPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new StaticClassNestedPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsPartialClass);
            var abstractClasses = new StaticTypeMemberListWrapper<TStaticClass, StaticClassNestedAbstractPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new StaticClassNestedAbstractPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsAbstractPartialClass);
            var sealedClasses = new StaticTypeMemberListWrapper<TStaticClass, StaticClassNestedSealedPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new StaticClassNestedSealedPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsSealedPartialClass);
            var staticClasses = new StaticTypeMemberListWrapper<TStaticClass, StaticClassNestedStaticPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new StaticClassNestedStaticPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsStaticPartialClass);
            return new StaticClassNestedPartialClassCollectionWithCodeAnalysis(classType.Members, abstractClasses, classes, sealedClasses, staticClasses);
        }
    }
}
