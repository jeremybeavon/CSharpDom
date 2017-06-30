using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        internal static StaticClassNestedPartialClassCollectionWithCodeAnalysis Create(StaticTypeWithCodeAnalysis classType)
        {
            var classes = new StaticTypeMemberListWrapper<StaticClassNestedPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new StaticClassNestedPartialClassWithCodeAnalysis());
            var abstractClasses = new StaticTypeMemberListWrapper<StaticClassNestedAbstractPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new StaticClassNestedAbstractPartialClassWithCodeAnalysis());
            var sealedClasses = new StaticTypeMemberListWrapper<StaticClassNestedSealedPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new StaticClassNestedSealedPartialClassWithCodeAnalysis());
            var staticClasses = new StaticTypeMemberListWrapper<StaticClassNestedStaticPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new StaticClassNestedStaticPartialClassWithCodeAnalysis());
            return new StaticClassNestedPartialClassCollectionWithCodeAnalysis(classType.Members, abstractClasses, classes, sealedClasses, staticClasses);
        }
    }
}
