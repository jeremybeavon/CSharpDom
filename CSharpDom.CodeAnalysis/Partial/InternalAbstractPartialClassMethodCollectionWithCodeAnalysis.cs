using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Partial
{
    internal sealed class InternalAbstractPartialClassMethodCollectionWithCodeAnalysis<TClass> :
        AbstractPartialClassMethodCollectionWithCodeAnalysis
        where TClass : class, IHasNode<ClassDeclarationSyntax>
    {
        private readonly InternalClassTypeWithCodeAnalysis<TClass> classType;
        private readonly ClassMethodListWrapper<TClass, ClassMethodWithCodeAnalysis> methods;
        private readonly ClassMethodListWrapper<TClass, AbstractMethodWithCodeAnalysis> abstractMethods;
        private readonly ClassMethodListWrapper<TClass, PartialMethodDefinitionWithCodeAnalysis> partialMethodDefinitions;
        private readonly ClassMethodListWrapper<TClass, PartialMethodImplementationWithCodeAnalysis> partialMethodImplementations;

        internal InternalAbstractPartialClassMethodCollectionWithCodeAnalysis(
            InternalClassTypeWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            methods = new ClassMethodListWrapper<TClass, ClassMethodWithCodeAnalysis>(
                classType.InternalNode,
                () => new ClassMethodWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier == null && !syntax.Modifiers.IsAbstract() && !syntax.IsPartial());
            abstractMethods = new ClassMethodListWrapper<TClass, AbstractMethodWithCodeAnalysis>(
                classType.InternalNode,
                () => new AbstractMethodWithCodeAnalysis(),
                syntax => syntax.Modifiers.IsAbstract());
            partialMethodDefinitions = new ClassMethodListWrapper<TClass, PartialMethodDefinitionWithCodeAnalysis>(
                classType.InternalNode,
                () => new PartialMethodDefinitionWithCodeAnalysis(),
                syntax => syntax.IsPartial() && syntax.Body == null);
            partialMethodImplementations = new ClassMethodListWrapper<TClass, PartialMethodImplementationWithCodeAnalysis>(
                classType.InternalNode,
                () => new PartialMethodImplementationWithCodeAnalysis(),
                syntax => syntax.IsPartial() && syntax.Body != null);
            classType.Members.AddClassPartialMethods(this);
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

        public override ICollection<ClassMethodWithCodeAnalysis> Methods
        {
            get { return methods; }
            set { classType.Members.CombineList(nameof(Methods), value.Select(item => item.Syntax)); }
        }

        public override ICollection<PartialMethodDefinitionWithCodeAnalysis> PartialMethodDefinitions
        {
            get => partialMethodDefinitions;
            set => classType.Members.CombineList(nameof(PartialMethodDefinitions), value.Select(item => item.Syntax));
        }

        public override ICollection<PartialMethodImplementationWithCodeAnalysis> PartialMethodImplementations
        {
            get => partialMethodImplementations;
            set => classType.Members.CombineList(nameof(PartialMethodDefinitions), value.Select(item => item.Syntax));
        }
    }
}
