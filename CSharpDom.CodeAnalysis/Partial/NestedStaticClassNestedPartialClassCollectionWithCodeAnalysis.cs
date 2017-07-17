using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class NestedStaticClassNestedPartialClassCollectionWithCodeAnalysis :
        GenericPartialClassCollectionWithCodeAnalysis<
            NestedStaticClassNestedPartialClassWithCodeAnalysis,
            NestedStaticClassNestedAbstractPartialClassWithCodeAnalysis,
            NestedStaticClassNestedSealedPartialClassWithCodeAnalysis,
            NestedStaticClassNestedStaticPartialClassWithCodeAnalysis>
    {
        private NestedStaticClassNestedPartialClassCollectionWithCodeAnalysis(
            IMemberList members,
            ICollection<NestedStaticClassNestedAbstractPartialClassWithCodeAnalysis> abstractClasses,
            ICollection<NestedStaticClassNestedPartialClassWithCodeAnalysis> classes,
            ICollection<NestedStaticClassNestedSealedPartialClassWithCodeAnalysis> sealedClasses,
            ICollection<NestedStaticClassNestedStaticPartialClassWithCodeAnalysis> staticClasses)
            : base(members, abstractClasses, classes, sealedClasses, staticClasses)
        {
        }

        internal static NestedStaticClassNestedPartialClassCollectionWithCodeAnalysis Create<TStaticClass>(
            InternalNestedStaticClassWithCodeAnalysis<TStaticClass> classType)
            where TStaticClass : class, IHasSyntax<ClassDeclarationSyntax>
        {
            var classes = new ClassMemberListWrapper<TStaticClass, NestedStaticClassNestedPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new NestedStaticClassNestedPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsPartialClass);
            var abstractClasses = new ClassMemberListWrapper<TStaticClass, NestedStaticClassNestedAbstractPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new NestedStaticClassNestedAbstractPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsAbstractPartialClass);
            var sealedClasses = new ClassMemberListWrapper<TStaticClass, NestedStaticClassNestedSealedPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new NestedStaticClassNestedSealedPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsSealedPartialClass);
            var staticClasses = new ClassMemberListWrapper<TStaticClass, NestedStaticClassNestedStaticPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new NestedStaticClassNestedStaticPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsStaticPartialClass);
            return new NestedStaticClassNestedPartialClassCollectionWithCodeAnalysis(classType.Members, abstractClasses, classes, sealedClasses, staticClasses);
        }
    }
}
