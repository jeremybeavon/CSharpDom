using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using CSharpDom.NotSupported.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructNestedInterfaceCollectionWithCodeAnalysis :
        EditableStructNestedInterfaceCollection<StructNestedInterfaceWithCodeAnalysis, PartialInterfaceNotSupported>
    {
        private readonly StructTypeWithCodeAnalysis classType;
        private readonly StructTypeMemberListWrapper<StructNestedInterfaceWithCodeAnalysis, InterfaceDeclarationSyntax> interfaces;

        internal StructNestedInterfaceCollectionWithCodeAnalysis(StructTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
            interfaces = new StructTypeMemberListWrapper<StructNestedInterfaceWithCodeAnalysis, InterfaceDeclarationSyntax>(
                classType.Node,
                () => new StructNestedInterfaceWithCodeAnalysis());
        }

        public override ICollection<StructNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return interfaces; }
            set { classType.Members.CombineList(nameof(Interfaces), interfaces.Select(item => item.Syntax)); }
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
