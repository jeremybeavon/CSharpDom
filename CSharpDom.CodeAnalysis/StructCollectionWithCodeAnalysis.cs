using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructCollectionWithCodeAnalysis :
        EditableStructCollection<StructWithCodeAnalysis, PartialStructWithCodeAnalysis>
    {
        private readonly IMemberList members;
        private readonly ICollection<StructWithCodeAnalysis> structs;
        private readonly ICollection<PartialStructWithCodeAnalysis> partialStructs;

        internal StructCollectionWithCodeAnalysis(NamespaceWithCodeAnalysis @namespace)
        {
            members = @namespace.Members;
            structs = new NamespaceMemberListWrapper<StructWithCodeAnalysis, StructDeclarationSyntax>(
                @namespace.Node,
                () => new StructWithCodeAnalysis(@namespace.Document),
                syntax => !syntax.IsPartial());
            partialStructs = new NamespaceMemberListWrapper<PartialStructWithCodeAnalysis, StructDeclarationSyntax>(
                @namespace.Node,
                () => new PartialStructWithCodeAnalysis(@namespace.Document),
                StructDeclarationSyntaxExtensions.IsPartial);
        }

        internal StructCollectionWithCodeAnalysis(LoadedDocumentWithCodeAnalysis document)
        {
            members = document.Members;
            structs = new LoadedDocumentMemberListWrapper<StructWithCodeAnalysis, StructDeclarationSyntax>(
                document.Node,
                () => new StructWithCodeAnalysis(document.Document),
                syntax => !syntax.IsPartial());
            partialStructs = new LoadedDocumentMemberListWrapper<PartialStructWithCodeAnalysis, StructDeclarationSyntax>(
                document.Node,
                () => new PartialStructWithCodeAnalysis(document.Document),
                StructDeclarationSyntaxExtensions.IsPartial);
        }

        public override ICollection<PartialStructWithCodeAnalysis> PartialStructs
        {
            get { return partialStructs; }
            set { members.CombineList(nameof(PartialStructs), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StructWithCodeAnalysis> Structs
        {
            get { return structs; }
            set { members.CombineList(nameof(Structs), value.Select(item => item.Syntax)); }
        }
    }
}
