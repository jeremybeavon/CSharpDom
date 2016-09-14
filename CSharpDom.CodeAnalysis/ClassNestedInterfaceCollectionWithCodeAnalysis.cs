using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using CSharpDom.NotSupported.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassNestedInterfaceCollectionWithCodeAnalysis :
        EditableClassNestedInterfaceCollection<ClassNestedInterfaceWithCodeAnalysis, PartialInterfaceNotSupported>
    {
        private readonly ClassTypeWithCodeAnalysis classType;
        private readonly ClassMemberListWrapper<
            InterfaceTypeWithCodeAnalysis,
            ClassNestedInterfaceWithCodeAnalysis,
            InterfaceDeclarationSyntax> interfaces;

        internal ClassNestedInterfaceCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
            interfaces = new ClassMemberListWrapper<InterfaceTypeWithCodeAnalysis, ClassNestedInterfaceWithCodeAnalysis, InterfaceDeclarationSyntax>(
                classType.Node,
                () => new ClassNestedInterfaceWithCodeAnalysis());
        }
        
        public override ICollection<ClassNestedInterfaceWithCodeAnalysis> Interfaces
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

        internal IChildCollection<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax> InterfaceList
        {
            get { return interfaces; }
        }
    }
}
