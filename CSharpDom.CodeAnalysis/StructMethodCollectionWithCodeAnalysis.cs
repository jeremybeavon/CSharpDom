﻿using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructMethodCollectionWithCodeAnalysis :
        EditableStructMethodCollection<StructMethodWithCodeAnalysis, ExplicitInterfaceMethodWithCodeAnalysis>
    {
        private readonly StructTypeWithCodeAnalysis structType;
        private readonly StructTypeMemberListWrapper<
            MethodWithCodeAnalysis,
            ExplicitInterfaceMethodWithCodeAnalysis,
            MethodDeclarationSyntax> explicitInterfaceMethods;
        private readonly StructTypeMemberListWrapper<
            MethodWithCodeAnalysis,
            StructMethodWithCodeAnalysis,
            MethodDeclarationSyntax> methods;

        internal StructMethodCollectionWithCodeAnalysis(StructTypeWithCodeAnalysis structType)
        {
            this.structType = structType;
            explicitInterfaceMethods = new StructTypeMemberListWrapper<MethodWithCodeAnalysis, ExplicitInterfaceMethodWithCodeAnalysis, MethodDeclarationSyntax>(
                structType.Node,
                () => new ExplicitInterfaceMethodWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier != null);
            methods = new StructTypeMemberListWrapper<MethodWithCodeAnalysis, StructMethodWithCodeAnalysis, MethodDeclarationSyntax>(
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

        internal IChildCollection<MethodWithCodeAnalysis, MethodDeclarationSyntax> ExplicitInterfaceMethodList
        {
            get { return explicitInterfaceMethods; }
        }

        internal IChildCollection<MethodWithCodeAnalysis, MethodDeclarationSyntax> MethodList
        {
            get { return methods; }
        }
    }
}
