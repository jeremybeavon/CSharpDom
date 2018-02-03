using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using CSharpDom.CodeAnalysis.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalStructNestedStructCollectionWithCodeAnalysis<TStruct> :
        StructNestedStructCollectionWithCodeAnalysis
        where TStruct : class, IHasNode<StructDeclarationSyntax>
    {
        private readonly InternalStructTypeWithCodeAnalysis<TStruct> structType;
        private readonly StructTypeMemberListWrapper<
            TStruct,
            StructNestedStructWithCodeAnalysis,
            StructDeclarationSyntax> structs;
        private readonly StructTypeMemberListWrapper<
            TStruct,
            StructNestedPartialStructWithCodeAnalysis,
            StructDeclarationSyntax> partialStructs;

        internal InternalStructNestedStructCollectionWithCodeAnalysis(InternalStructTypeWithCodeAnalysis<TStruct> structType)
        {
            this.structType = structType;
            structs = new StructTypeMemberListWrapper<TStruct, StructNestedStructWithCodeAnalysis, StructDeclarationSyntax>(
                structType.InternalNode,
                () => new StructNestedStructWithCodeAnalysis(),
                syntax => !syntax.IsPartial());
            partialStructs = new StructTypeMemberListWrapper<TStruct, StructNestedPartialStructWithCodeAnalysis, StructDeclarationSyntax>(
                structType.InternalNode,
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
