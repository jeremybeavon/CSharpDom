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

        internal static StaticClassNestedPartialClassCollectionWithCodeAnalysis Create<TClass>(
            InternalStaticTypeWithCodeAnalysis<TClass> classType)
            where TClass : class, IHasSyntax<ClassDeclarationSyntax>
        {
            var classes = new ClassMemberListWrapper<TClass, StaticClassNestedPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.InternalNode,
                () => new StaticClassNestedPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsPartialClass);
            var abstractClasses = new ClassMemberListWrapper<TClass, StaticClassNestedAbstractPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.InternalNode,
                () => new StaticClassNestedAbstractPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsAbstractPartialClass);
            var sealedClasses = new ClassMemberListWrapper<TClass, StaticClassNestedSealedPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.InternalNode,
                () => new StaticClassNestedSealedPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsSealedPartialClass);
            var staticClasses = new ClassMemberListWrapper<TClass, StaticClassNestedStaticPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.InternalNode,
                () => new StaticClassNestedStaticPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsStaticPartialClass);
            return new StaticClassNestedPartialClassCollectionWithCodeAnalysis(classType.Members, abstractClasses, classes, sealedClasses, staticClasses);
        }
    }
}
