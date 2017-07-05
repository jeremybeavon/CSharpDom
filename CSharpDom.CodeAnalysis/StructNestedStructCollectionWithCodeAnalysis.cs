using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructNestedStructCollectionWithCodeAnalysis :
        EditableStructNestedStructCollection<StructNestedStructWithCodeAnalysis, StructNestedPartialStructWithCodeAnalysis>
    {
        private readonly StructTypeWithCodeAnalysis structType;
        private readonly StructTypeMemberListWrapper<StructNestedStructWithCodeAnalysis, StructDeclarationSyntax> structs;
        private readonly StructTypeMemberListWrapper<
            StructNestedPartialStructWithCodeAnalysis,
            StructDeclarationSyntax> partialStructs;

        internal StructNestedStructCollectionWithCodeAnalysis(StructTypeWithCodeAnalysis structType)
        {
            this.structType = structType;
            structs = new StructTypeMemberListWrapper<StructNestedStructWithCodeAnalysis, StructDeclarationSyntax>(
                structType.Node,
                () => new StructNestedStructWithCodeAnalysis(),
                syntax => !syntax.IsPartial());
            partialStructs = new StructTypeMemberListWrapper<StructNestedPartialStructWithCodeAnalysis, StructDeclarationSyntax>(
                structType.Node,
                () => new StructNestedPartialStructWithCodeAnalysis(),
                StructDeclarationSyntaxExtensions.IsPartial);
        }

        public override ICollection<StructNestedPartialStructWithCodeAnalysis> PartialStructs
        {
            get { return partialStructs; }
            set { structType.Members.CombineList(nameof(PartialStructs), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StructNestedStructWithCodeAnalysis> Structs
        {
            get { return structs; }
            set { structType.Members.CombineList(nameof(Structs), value.Select(item => item.Syntax)); }
        }
    }
}
