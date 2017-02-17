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
                () => new StructWithCodeAnalysis());
        }

        internal StructCollectionWithCodeAnalysis(LoadedDocumentWithCodeAnalysis document)
        {
            members = document.Members;
            structs = new LoadedDocumentMemberListWrapper<StructWithCodeAnalysis, StructDeclarationSyntax>(
                document.Node,
                () => new StructWithCodeAnalysis());
        }

        public override ICollection<PartialStructNotSupported> PartialStructs
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override ICollection<StructWithCodeAnalysis> Structs
        {
            get { return structs; }
            set { members.CombineList(nameof(Structs), value.Select(item => item.Syntax)); }
        }
    }
}
