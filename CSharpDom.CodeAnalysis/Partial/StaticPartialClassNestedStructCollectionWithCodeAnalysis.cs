using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StaticPartialClassNestedStructCollectionWithCodeAnalysis :
        EditableStaticClassNestedStructCollection<
            StaticPartialClassNestedStructWithCodeAnalysis,
            StaticPartialClassNestedPartialStructWithCodeAnalysis>
    {
        private readonly StaticPartialClassWithCodeAnalysis type;
        private readonly StaticPartialClassMemberListWrapper<
            StaticPartialClassNestedStructWithCodeAnalysis,
            StructDeclarationSyntax> structs;
        private readonly StaticPartialClassMemberListWrapper<
            StaticPartialClassNestedPartialStructWithCodeAnalysis,
            StructDeclarationSyntax> partialStructs;

        internal StaticPartialClassNestedStructCollectionWithCodeAnalysis(StaticPartialClassWithCodeAnalysis type)
        {
            this.type = type;
            structs = new StaticPartialClassMemberListWrapper<StaticPartialClassNestedStructWithCodeAnalysis, StructDeclarationSyntax>(
                type.Node,
                () => new StaticPartialClassNestedStructWithCodeAnalysis());
            partialStructs = new StaticPartialClassMemberListWrapper<StaticPartialClassNestedPartialStructWithCodeAnalysis, StructDeclarationSyntax>(
                type.Node,
                () => new StaticPartialClassNestedPartialStructWithCodeAnalysis());
        }

        public override ICollection<StaticPartialClassNestedPartialStructWithCodeAnalysis> PartialStructs
        {
            get { return partialStructs; }
            set { type.Members.CombineList(nameof(PartialStructs), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StaticPartialClassNestedStructWithCodeAnalysis> Structs
        {
            get { return structs; }
            set { type.Members.CombineList(nameof(Structs), value.Select(item => item.Syntax)); }
        }
    }
}
