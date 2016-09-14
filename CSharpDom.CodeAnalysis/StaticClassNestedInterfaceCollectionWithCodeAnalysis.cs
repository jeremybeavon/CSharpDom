using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using CSharpDom.NotSupported.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassNestedInterfaceCollectionWithCodeAnalysis :
        EditableStaticClassNestedInterfaceCollection<StaticClassNestedInterfaceWithCodeAnalysis, PartialInterfaceNotSupported>
    {
        private readonly StaticTypeWithCodeAnalysis staticType;
        private readonly StaticTypeMemberListWrapper<
            InterfaceTypeWithCodeAnalysis,
            StaticClassNestedInterfaceWithCodeAnalysis,
            InterfaceDeclarationSyntax> interfaces;

        internal StaticClassNestedInterfaceCollectionWithCodeAnalysis(StaticTypeWithCodeAnalysis staticType)
        {
            this.staticType = staticType;
            interfaces = new StaticTypeMemberListWrapper<InterfaceTypeWithCodeAnalysis, StaticClassNestedInterfaceWithCodeAnalysis, InterfaceDeclarationSyntax>(
                staticType.Node,
                () => new StaticClassNestedInterfaceWithCodeAnalysis());
        }
        
        public override ICollection<StaticClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return interfaces; }
            set { staticType.Members.CombineList(nameof(Interfaces), value.Select(item => item.Syntax)); }
        }

        internal IChildCollection<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax> InterfaceList
        {
            get { return interfaces; }
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
