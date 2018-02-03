using System.Collections.Generic;
using System.Linq;
using CSharpDom.CodeAnalysis.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalNestedStaticClassNestedStructCollectionWithCodeAnalysis<TStaticClass> :
        NestedStaticClassNestedStructCollectionWithCodeAnalysis
        where TStaticClass : class, IHasNode<ClassDeclarationSyntax>
    {
        private readonly InternalNestedStaticClassWithCodeAnalysis<TStaticClass> type;
        private readonly ClassMemberListWrapper<
            TStaticClass,
            NestedStaticClassNestedStructWithCodeAnalysis,
            StructDeclarationSyntax> structs;
        private readonly ClassMemberListWrapper<
            TStaticClass,
            NestedStaticClassNestedPartialStructWithCodeAnalysis,
            StructDeclarationSyntax> partialStructs;

        internal InternalNestedStaticClassNestedStructCollectionWithCodeAnalysis(
            InternalNestedStaticClassWithCodeAnalysis<TStaticClass> type)
        {
            this.type = type;
            structs = new ClassMemberListWrapper<TStaticClass, NestedStaticClassNestedStructWithCodeAnalysis, StructDeclarationSyntax>(
                type.InternalNode,
                () => new NestedStaticClassNestedStructWithCodeAnalysis(),
                syntax => !syntax.IsPartial());
            partialStructs = new ClassMemberListWrapper<TStaticClass, NestedStaticClassNestedPartialStructWithCodeAnalysis, StructDeclarationSyntax>(
                type.InternalNode,
                () => new NestedStaticClassNestedPartialStructWithCodeAnalysis(),
                StructDeclarationSyntaxExtensions.IsPartial);
        }

        public override ICollection<NestedStaticClassNestedPartialStructWithCodeAnalysis> PartialStructs
        {
            get { return partialStructs; }
            set { type.Members.CombineList(nameof(PartialStructs), value.Select(item => item.Syntax)); }
        }

        public override ICollection<NestedStaticClassNestedStructWithCodeAnalysis> Structs
        {
            get { return structs; }
            set { type.Members.CombineList(nameof(Structs), value.Select(item => item.Syntax)); }
        }
    }
}
