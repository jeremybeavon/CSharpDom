using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractClassMethodCollectionWithCodeAnalysis :
        EditableAbstractClassMethodCollection<
            ClassMethodWithCodeAnalysis,
            AbstractMethodWithCodeAnalysis,
            ExplicitInterfaceMethodWithCodeAnalysis>
    {
        private readonly ClassTypeWithCodeAnalysis classType;
        private readonly ClassMethodListWrapper<ClassMethodWithCodeAnalysis> methods;
        private readonly ClassMethodListWrapper<AbstractMethodWithCodeAnalysis> abstractMethods;

        internal AbstractClassMethodCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
            methods = new ClassMethodListWrapper<ClassMethodWithCodeAnalysis>(
                classType.Node,
                parent => new ClassMethodWithCodeAnalysis(parent, ClassType.Abstract),
                (child, parent) => child.Method.Method.SetClassParent(parent, ClassType.Abstract),
                syntax => syntax.ExplicitInterfaceSpecifier == null && !syntax.Modifiers.IsAbstract());
            abstractMethods = new ClassMethodListWrapper<AbstractMethodWithCodeAnalysis>(
                classType.Node,
                parent => new AbstractMethodWithCodeAnalysis(parent),
                (child, parent) => child.Method.AbstractClassParent = parent,
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

        public override ICollection<ClassMethodWithCodeAnalysis> Methods
        {
            get { return methods; }
            set { classType.Members.CombineList(nameof(Methods), value.Select(item => item.Syntax)); }
        }

        internal IChildCollection<MethodWithCodeAnalysis, MethodDeclarationSyntax> AbstractMethodList
        {
            get { return abstractMethods; }
        }
        
        internal IChildCollection<MethodWithCodeAnalysis, MethodDeclarationSyntax> MethodList
        {
            get { return methods; }
        }
    }
}
