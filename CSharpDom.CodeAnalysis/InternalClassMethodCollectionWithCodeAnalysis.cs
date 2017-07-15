using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalClassMethodCollectionWithCodeAnalysis<TClass> :
        ClassMethodCollectionWithCodeAnalysis
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalClassTypeWithCodeAnalysis<TClass> classType;
        private readonly ClassMethodListWrapper<TClass, ExplicitInterfaceMethodWithCodeAnalysis> explicitInterfaceMethods;
        private readonly ClassMethodListWrapper<TClass, ClassMethodWithCodeAnalysis> methods;

        internal InternalClassMethodCollectionWithCodeAnalysis(InternalClassTypeWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            explicitInterfaceMethods = new ClassMethodListWrapper<TClass, ExplicitInterfaceMethodWithCodeAnalysis>(
                classType.Node,
                () => new ExplicitInterfaceMethodWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier != null);
            methods = new ClassMethodListWrapper<TClass, ClassMethodWithCodeAnalysis>(
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
