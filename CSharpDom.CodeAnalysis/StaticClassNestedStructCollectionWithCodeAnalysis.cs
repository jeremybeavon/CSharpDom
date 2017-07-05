using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.Common;
using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassNestedStructCollectionWithCodeAnalysis :
        EditableStaticClassNestedStructCollection<
            StaticClassNestedStructWithCodeAnalysis,
            StaticClassNestedPartialStructWithCodeAnalysis>
    {
        private readonly StaticTypeWithCodeAnalysis type;
        private readonly StaticTypeMemberListWrapper<
            StaticClassNestedStructWithCodeAnalysis,
            StructDeclarationSyntax> structs;
        private readonly StaticTypeMemberListWrapper<
            StaticClassNestedPartialStructWithCodeAnalysis,
            StructDeclarationSyntax> partialStructs;

        internal StaticClassNestedStructCollectionWithCodeAnalysis(StaticTypeWithCodeAnalysis type)
        {
            this.type = type;
            structs = new StaticTypeMemberListWrapper<StaticClassNestedStructWithCodeAnalysis, StructDeclarationSyntax>(
                type.Node,
                () => new StaticClassNestedStructWithCodeAnalysis());
            partialStructs = new StaticTypeMemberListWrapper<StaticClassNestedPartialStructWithCodeAnalysis, StructDeclarationSyntax>(
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
