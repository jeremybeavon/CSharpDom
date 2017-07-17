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

        internal static StaticClassNestedPartialClassCollectionWithCodeAnalysis Create(
            StaticClassWithCodeAnalysis classType)
        {
            var classes = new StaticClassMemberListWrapper<StaticClassNestedPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new StaticClassNestedPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsPartialClass);
            var abstractClasses = new StaticClassMemberListWrapper<StaticClassNestedAbstractPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new StaticClassNestedAbstractPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsAbstractPartialClass);
            var sealedClasses = new StaticClassMemberListWrapper<StaticClassNestedSealedPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new StaticClassNestedSealedPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsSealedPartialClass);
            var staticClasses = new StaticClassMemberListWrapper<StaticClassNestedStaticPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new StaticClassNestedStaticPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsStaticPartialClass);
            return new StaticClassNestedPartialClassCollectionWithCodeAnalysis(classType.Members, abstractClasses, classes, sealedClasses, staticClasses);
        }
    }
}
