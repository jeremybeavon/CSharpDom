﻿using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassMethodCollectionWithCodeAnalysis :
        EditableClassMethodCollection<ClassMethodWithCodeAnalysis, ExplicitInterfaceMethodWithCodeAnalysis>
    {
        private readonly ClassTypeWithCodeAnalysis classType;
        private readonly ClassMethodListWrapper<ExplicitInterfaceMethodWithCodeAnalysis> explicitInterfaceMethods;
        private readonly ClassMethodListWrapper<ClassMethodWithCodeAnalysis> methods;

        internal ClassMethodCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
            explicitInterfaceMethods = new ClassMethodListWrapper<ExplicitInterfaceMethodWithCodeAnalysis>(
                classType.Node,
                () => new ExplicitInterfaceMethodWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier != null);
            methods = new ClassMethodListWrapper<ClassMethodWithCodeAnalysis>(
                classType.Node,
                () => new ClassMethodWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier == null);
        }

        public override ICollection<ExplicitInterfaceMethodWithCodeAnalysis> ExplicitInterfaceMethods
        {
            get { return explicitInterfaceMethods; }
            set { classType.Members.CombineList(nameof(ExplicitInterfaceMethods), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ClassMethodWithCodeAnalysis> Methods
        {
            get { return methods; }
            set { classType.Members.CombineList(nameof(Methods), value.Select(item => item.Syntax)); }
        }
    }
}
