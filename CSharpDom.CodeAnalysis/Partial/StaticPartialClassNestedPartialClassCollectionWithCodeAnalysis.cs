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
            StaticPartialClassWithCodeAnalysis classType)
        {
            var classes = new StaticPartialClassMemberListWrapper<StaticPartialClassNestedPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new StaticPartialClassNestedPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsPartialClass);
            var abstractClasses = new StaticPartialClassMemberListWrapper<StaticPartialClassNestedAbstractPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new StaticPartialClassNestedAbstractPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsAbstractPartialClass);
            var sealedClasses = new StaticPartialClassMemberListWrapper<StaticPartialClassNestedSealedPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new StaticPartialClassNestedSealedPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsSealedPartialClass);
            var staticClasses = new StaticPartialClassMemberListWrapper<StaticPartialClassNestedStaticPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new StaticPartialClassNestedStaticPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsStaticPartialClass);
            return new StaticPartialClassNestedPartialClassCollectionWithCodeAnalysis(classType.Members, abstractClasses, classes, sealedClasses, staticClasses);
        }
    }
}
