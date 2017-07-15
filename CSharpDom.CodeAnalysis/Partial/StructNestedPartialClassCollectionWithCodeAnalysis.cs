using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StructNestedPartialClassCollectionWithCodeAnalysis :
        GenericPartialClassCollectionWithCodeAnalysis<
            StructNestedPartialClassWithCodeAnalysis,
            StructNestedAbstractPartialClassWithCodeAnalysis,
            StructNestedSealedPartialClassWithCodeAnalysis,
            StructNestedStaticPartialClassWithCodeAnalysis>
    {
        private StructNestedPartialClassCollectionWithCodeAnalysis(
            IMemberList members,
            ICollection<StructNestedAbstractPartialClassWithCodeAnalysis> abstractClasses,
            ICollection<StructNestedPartialClassWithCodeAnalysis> classes,
            ICollection<StructNestedSealedPartialClassWithCodeAnalysis> sealedClasses,
            ICollection<StructNestedStaticPartialClassWithCodeAnalysis> staticClasses)
            : base(members, abstractClasses, classes, sealedClasses, staticClasses)
        {
        }

        internal static StructNestedPartialClassCollectionWithCodeAnalysis Create<TStruct>(
            InternalStructTypeWithCodeAnalysis<TStruct> structType)
            where TStruct : class, IHasSyntax<StructDeclarationSyntax>
        {
            var classes = new StructTypeMemberListWrapper<TStruct, StructNestedPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                structType.Node,
                () => new StructNestedPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsPartialClass);
            var abstractClasses = new StructTypeMemberListWrapper<TStruct, StructNestedAbstractPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                structType.Node,
                () => new StructNestedAbstractPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsAbstractPartialClass);
            var sealedClasses = new StructTypeMemberListWrapper<TStruct, StructNestedSealedPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                structType.Node,
                () => new StructNestedSealedPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsSealedPartialClass);
            var staticClasses = new StructTypeMemberListWrapper<TStruct, StructNestedStaticPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                structType.Node,
                () => new StructNestedStaticPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsStaticPartialClass);
            return new StructNestedPartialClassCollectionWithCodeAnalysis(structType.Members, abstractClasses, classes, sealedClasses, staticClasses);
        }
    }
}
