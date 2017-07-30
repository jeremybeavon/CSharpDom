using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalStaticClassNestedStructCollectionWithCodeAnalysis<TClass> :
        StaticClassNestedStructCollectionWithCodeAnalysis
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalStaticTypeWithCodeAnalysis<TClass> type;
        private readonly ClassMemberListWrapper<
            TClass,
            StaticClassNestedStructWithCodeAnalysis,
            StructDeclarationSyntax> structs;
        private readonly ClassMemberListWrapper<
            TClass,
            StaticClassNestedPartialStructWithCodeAnalysis,
            StructDeclarationSyntax> partialStructs;

        internal InternalStaticClassNestedStructCollectionWithCodeAnalysis(
            InternalStaticTypeWithCodeAnalysis<TClass> type)
        {
            this.type = type;
            structs = new ClassMemberListWrapper<TClass, StaticClassNestedStructWithCodeAnalysis, StructDeclarationSyntax>(
                type.InternalNode,
                () => new StaticClassNestedStructWithCodeAnalysis());
            partialStructs = new ClassMemberListWrapper<TClass, StaticClassNestedPartialStructWithCodeAnalysis, StructDeclarationSyntax>(
                type.InternalNode,
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
