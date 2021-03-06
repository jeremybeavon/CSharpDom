﻿using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalAbstractClassMethodCollectionWithCodeAnalysis<TClass> :
        AbstractClassMethodCollectionWithCodeAnalysis
        where TClass : class, IHasNode<ClassDeclarationSyntax>
    {
        private readonly InternalClassTypeWithCodeAnalysis<TClass> classType;
        private readonly ClassMethodListWrapper<TClass, AbstractClassMethodWithCodeAnalysis> methods;
        private readonly ClassMethodListWrapper<TClass, AbstractMethodWithCodeAnalysis> abstractMethods;

        internal InternalAbstractClassMethodCollectionWithCodeAnalysis(InternalClassTypeWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            methods = new ClassMethodListWrapper<TClass, AbstractClassMethodWithCodeAnalysis>(
                classType.InternalNode,
                () => new AbstractClassMethodWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier == null && !syntax.Modifiers.IsAbstract());
            abstractMethods = new ClassMethodListWrapper<TClass, AbstractMethodWithCodeAnalysis>(
                classType.InternalNode,
                () => new AbstractMethodWithCodeAnalysis(),
                syntax => syntax.Modifiers.IsAbstract());
        }

        public override ICollection<AbstractMethodWithCodeAnalysis> AbstractMethods
        {
            get { return abstractMethods; }
            set { classType.Members.CombineList(nameof(AbstractMethods), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ExplicitInterfaceMethodWithCodeAnalysis> ExplicitInterfaceMethods
        {
            get { return classType.Methods.ExplicitInterfaceMethods; }
            set { classType.Methods.ExplicitInterfaceMethods = value; }
        }

        public override ICollection<AbstractClassMethodWithCodeAnalysis> Methods
        {
            get { return methods; }
            set { classType.Members.CombineList(nameof(Methods), value.Select(item => item.Syntax)); }
        }
    }
}
