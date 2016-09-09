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
        private readonly StructTypeMemberListWrapper<
            InterfaceTypeWithCodeAnalysis,
            StructNestedInterfaceWithCodeAnalysis,
            InterfaceDeclarationSyntax> interfaces;

        internal StructNestedInterfaceCollectionWithCodeAnalysis(StructTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
            interfaces = new StructTypeMemberListWrapper<InterfaceTypeWithCodeAnalysis, StructNestedInterfaceWithCodeAnalysis, InterfaceDeclarationSyntax>(
                classType.Node,
                parent => new StructNestedInterfaceWithCodeAnalysis(parent),
                (child, parent) => child.Interface.Interface.StructParent = parent);
        }

        public override ICollection<StructNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return interfaces; }
            set { classType.Members.CombineList(nameof(Interfaces), interfaces.Select(item => item.Syntax)); }
        }

        internal IChildCollection<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax> InterfaceList
        {
            get { return interfaces; }
        }
    }
}
