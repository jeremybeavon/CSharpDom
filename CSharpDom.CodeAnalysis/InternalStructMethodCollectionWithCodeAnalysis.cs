using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalStructMethodCollectionWithCodeAnalysis<TStruct> :
        StructMethodCollectionWithCodeAnalysis
        where TStruct : class, IHasSyntax<StructDeclarationSyntax>
    {
        private readonly InternalStructTypeWithCodeAnalysis<TStruct> structType;
        private readonly StructTypeMemberListWrapper<
            TStruct,
            ExplicitInterfaceMethodWithCodeAnalysis,
            MethodDeclarationSyntax> explicitInterfaceMethods;
        private readonly StructTypeMemberListWrapper<
            TStruct,
            StructMethodWithCodeAnalysis,
            MethodDeclarationSyntax> methods;

        internal InternalStructMethodCollectionWithCodeAnalysis(InternalStructTypeWithCodeAnalysis<TStruct> structType)
        {
            this.structType = structType;
            explicitInterfaceMethods = new StructTypeMemberListWrapper<TStruct, ExplicitInterfaceMethodWithCodeAnalysis, MethodDeclarationSyntax>(
                structType.Node,
                () => new ExplicitInterfaceMethodWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier != null);
            methods = new StructTypeMemberListWrapper<TStruct, StructMethodWithCodeAnalysis, MethodDeclarationSyntax>(
                structType.Node,
                () => new StructMethodWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier == null);
        }

        public override ICollection<ExplicitInterfaceMethodWithCodeAnalysis> ExplicitInterfaceMethods
        {
            get { return explicitInterfaceMethods; }
            set { structType.Members.CombineList(nameof(ExplicitInterfaceMethods), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StructMethodWithCodeAnalysis> Methods
        {
            get { return methods; }
            set { structType.Members.CombineList(nameof(Methods), value.Select(item => item.Syntax)); }
        }
    }
}
