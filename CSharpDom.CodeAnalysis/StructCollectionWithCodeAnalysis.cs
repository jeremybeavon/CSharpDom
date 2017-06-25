using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using CSharpDom.NotSupported.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructCollectionWithCodeAnalysis :
        EditableStructCollection<StructWithCodeAnalysis, PartialStructNotSupported>
    {
        private readonly IMemberList members;
        private readonly ICollection<StructWithCodeAnalysis> structs;

        internal StructCollectionWithCodeAnalysis(NamespaceWithCodeAnalysis @namespace)
        {
            members = @namespace.Members;
            structs = new NamespaceMemberListWrapper<StructWithCodeAnalysis, StructDeclarationSyntax>(
                @namespace.Node,
                () => new StructWithCodeAnalysis(null));
        }

        internal StructCollectionWithCodeAnalysis(LoadedDocumentWithCodeAnalysis document)
        {
            members = document.Members;
            structs = new LoadedDocumentMemberListWrapper<StructWithCodeAnalysis, StructDeclarationSyntax>(
                document.Node,
                () => new StructWithCodeAnalysis(document.Document));
        }

        public override ICollection<PartialStructNotSupported> PartialStructs
        {
            get
            {
                return new PartialStructNotSupported[0];
            }

            set
            {
                throw new NotSupportedException();
            }
        }

        public override ICollection<StructWithCodeAnalysis> Structs
        {
            get { return structs; }
            set { members.CombineList(nameof(Structs), value.Select(item => item.Syntax)); }
        }
    }
}
