using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassNestedStructCollectionWithCodeAnalysis :
        EditableStaticClassNestedStructCollection<
            StaticClassNestedStructWithCodeAnalysis,
            StaticClassNestedPartialStructWithCodeAnalysis>
    {
        private readonly StaticClassWithCodeAnalysis type;
        private readonly StaticClassMemberListWrapper<
            StaticClassNestedStructWithCodeAnalysis,
            StructDeclarationSyntax> structs;
        private readonly StaticClassMemberListWrapper<
            StaticClassNestedPartialStructWithCodeAnalysis,
            StructDeclarationSyntax> partialStructs;

        internal StaticClassNestedStructCollectionWithCodeAnalysis(StaticClassWithCodeAnalysis type)
        {
            this.type = type;
            structs = new StaticClassMemberListWrapper<StaticClassNestedStructWithCodeAnalysis, StructDeclarationSyntax>(
                type.Node,
                () => new StaticClassNestedStructWithCodeAnalysis());
            partialStructs = new StaticClassMemberListWrapper<StaticClassNestedPartialStructWithCodeAnalysis, StructDeclarationSyntax>(
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
