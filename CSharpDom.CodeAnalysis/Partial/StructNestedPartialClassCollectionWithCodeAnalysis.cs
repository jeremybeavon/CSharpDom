using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        internal static StructNestedPartialClassCollectionWithCodeAnalysis Create(StructTypeWithCodeAnalysis structType)
        {
            var classes = new StructTypeMemberListWrapper<StructNestedPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                structType.Node,
                () => new StructNestedPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsPartialClass);
            var abstractClasses = new StructTypeMemberListWrapper<StructNestedAbstractPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                structType.Node,
                () => new StructNestedAbstractPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsAbstractPartialClass);
            var sealedClasses = new StructTypeMemberListWrapper<StructNestedSealedPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                structType.Node,
                () => new StructNestedSealedPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsSealedPartialClass);
            var staticClasses = new StructTypeMemberListWrapper<StructNestedStaticPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                structType.Node,
                () => new StructNestedStaticPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsStaticPartialClass);
            return new StructNestedPartialClassCollectionWithCodeAnalysis(structType.Members, abstractClasses, classes, sealedClasses, staticClasses);
        }
    }
}
