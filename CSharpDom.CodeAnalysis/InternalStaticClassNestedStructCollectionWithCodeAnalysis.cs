using System.Collections.Generic;
using System.Linq;
using CSharpDom.CodeAnalysis.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalStaticClassNestedStructCollectionWithCodeAnalysis<TStaticClass> :
        StaticClassNestedStructCollectionWithCodeAnalysis
        where TStaticClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalStaticTypeWithCodeAnalysis<TStaticClass> type;
        private readonly StaticTypeMemberListWrapper<
            TStaticClass,
            StaticClassNestedStructWithCodeAnalysis,
            StructDeclarationSyntax> structs;
        private readonly StaticTypeMemberListWrapper<
            TStaticClass,
            StaticClassNestedPartialStructWithCodeAnalysis,
            StructDeclarationSyntax> partialStructs;

        internal InternalStaticClassNestedStructCollectionWithCodeAnalysis(
            InternalStaticTypeWithCodeAnalysis<TStaticClass> type)
        {
            this.type = type;
            structs = new StaticTypeMemberListWrapper<TStaticClass, StaticClassNestedStructWithCodeAnalysis, StructDeclarationSyntax>(
                type.Node,
                () => new StaticClassNestedStructWithCodeAnalysis());
            partialStructs = new StaticTypeMemberListWrapper<TStaticClass, StaticClassNestedPartialStructWithCodeAnalysis, StructDeclarationSyntax>(
                type.Node,
                () => new StaticClassNestedPartialStructWithCodeAnalysis());
        }

        public override ICollection<StaticClassNestedPartialStructWithCodeAnalysis> PartialStructs
        {
            get { return partialStructs; }
            set { type.Members.CombineList(nameof(PartialStructs), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StaticClassNestedStructWithCodeAnalysis> Structs
        {
            get { return structs; }
            set { type.Members.CombineList(nameof(Structs), value.Select(item => item.Syntax)); }
        }
    }
}
