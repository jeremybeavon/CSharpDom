using System;
using System.Collections.Generic;
using CSharpDom.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class AbstractPartialClassMethodCollectionWithCodeAnalysis :
        EditableAbstractPartialClassMethodCollection<
            ClassMethodWithCodeAnalysis,
            AbstractMethodWithCodeAnalysis,
            ExplicitInterfaceMethodWithCodeAnalysis,
            PartialMethodDefinitionWithCodeAnalysis,
            PartialMethodImplementationWithCodeAnalysis>
    {
        private readonly ClassTypeWithCodeAnalysis classType;
        private readonly ClassMethodListWrapper<ClassMethodWithCodeAnalysis> methods;
        private readonly ClassMethodListWrapper<AbstractMethodWithCodeAnalysis> abstractMethods;
        private readonly ClassMethodListWrapper<PartialMethodDefinitionWithCodeAnalysis> partialMethodDefinitions;
        private readonly ClassMethodListWrapper<PartialMethodImplementationWithCodeAnalysis> partialMethodImplementations;

        internal AbstractPartialClassMethodCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
            methods = new ClassMethodListWrapper<ClassMethodWithCodeAnalysis>(
                classType.Node,
                () => new ClassMethodWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier == null && !syntax.Modifiers.IsAbstract() && !syntax.IsPartial());
            abstractMethods = new ClassMethodListWrapper<AbstractMethodWithCodeAnalysis>(
                classType.Node,
                () => new AbstractMethodWithCodeAnalysis(),
                syntax => syntax.Modifiers.IsAbstract());
            partialMethodDefinitions = new ClassMethodListWrapper<PartialMethodDefinitionWithCodeAnalysis>(
                classType.Node,
                () => new PartialMethodDefinitionWithCodeAnalysis(),
                syntax => syntax.IsPartial() && syntax.Body == null);
            partialMethodImplementations = new ClassMethodListWrapper<PartialMethodImplementationWithCodeAnalysis>(
                classType.Node,
                () => new PartialMethodImplementationWithCodeAnalysis(),
                syntax => syntax.IsPartial() && syntax.Body != null);
            classType.Members.AddPartialMethods(this);
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

        internal void Replace(AbstractPartialClassMethodCollectionWithCodeAnalysis value)
        {
            classType.Members.CombineList(
                new MemberListSyntax(nameof(AbstractMethods), value.AbstractMethods.Select(method => method.Syntax)),
                new MemberListSyntax(nameof(Methods), value.Methods.Select(method => method.Syntax)),
                new MemberListSyntax(nameof(ExplicitInterfaceMethods), value.ExplicitInterfaceMethods.Select(method => method.Syntax)),
                new MemberListSyntax(nameof(PartialMethodDefinitions), value.PartialMethodDefinitions.Select(method => method.Syntax)),
                new MemberListSyntax(nameof(PartialMethodImplementations), value.PartialMethodImplementations.Select(method => method.Syntax)));
        }
    }
}
