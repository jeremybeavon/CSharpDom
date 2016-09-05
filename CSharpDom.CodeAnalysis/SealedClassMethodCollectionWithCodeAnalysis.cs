﻿using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SealedClassMethodCollectionWithCodeAnalysis :
        EditableSealedClassMethodCollection<
            SealedClassMethodWithCodeAnalysis,
            ExplicitInterfaceMethodWithCodeAnalysis>
    {
        private readonly ClassTypeWithCodeAnalysis classType;
        private readonly ClassMethodListWrapper<SealedClassMethodWithCodeAnalysis> methods;

        internal SealedClassMethodCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
            methods = new ClassMethodListWrapper<SealedClassMethodWithCodeAnalysis>(
                classType.Node,
                parent => new SealedClassMethodWithCodeAnalysis(parent),
                (child, parent) => child.Method.Method.SealedClassParent = parent,
                syntax => syntax.ExplicitInterfaceSpecifier == null);
        }

        public override ICollection<ExplicitInterfaceMethodWithCodeAnalysis> ExplicitInterfaceMethods
        {
            get { return classType.Methods.ExplicitInterfaceMethods; }
            set { classType.Methods.ExplicitInterfaceMethods = value; }
        }

        public override ICollection<SealedClassMethodWithCodeAnalysis> Methods
        {
            get { return methods; }
            set { }
        }

        internal IChildCollection<MethodWithCodeAnalysis, MethodDeclarationSyntax> MethodList
        {
            get { return methods; }
        }
    }
}
