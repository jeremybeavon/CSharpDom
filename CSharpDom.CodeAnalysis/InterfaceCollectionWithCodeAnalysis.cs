using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using CSharpDom.NotSupported.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class InterfaceCollectionWithCodeAnalysis :
        EditableInterfaceCollection<InterfaceWithCodeAnalysis, PartialInterfaceNotSupported>
    {
        private readonly IMemberList members;
        private readonly ICollection<InterfaceWithCodeAnalysis> interfaces;

        internal InterfaceCollectionWithCodeAnalysis(NamespaceWithCodeAnalysis @namespace)
        {
            members = @namespace.Members;
            interfaces = new NamespaceMemberListWrapper<InterfaceWithCodeAnalysis, InterfaceDeclarationSyntax>(
                @namespace.Node,
                () => new InterfaceWithCodeAnalysis());
        }

        internal InterfaceCollectionWithCodeAnalysis(LoadedDocumentWithCodeAnalysis document)
        {
            members = document.Members;
            interfaces = new LoadedDocumentMemberListWrapper<InterfaceWithCodeAnalysis, InterfaceDeclarationSyntax>(
                document.Node,
                () => new InterfaceWithCodeAnalysis());
        }

        public override ICollection<InterfaceWithCodeAnalysis> Interfaces
        {
            get { return interfaces; }
            set { members.CombineList(nameof(Interfaces), value.Select(item => item.Syntax)); }
        }

        public override ICollection<PartialInterfaceNotSupported> PartialInterfaces
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
    }
}
