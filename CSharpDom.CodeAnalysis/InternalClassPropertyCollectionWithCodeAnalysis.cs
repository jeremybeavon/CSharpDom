using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalClassPropertyCollectionWithCodeAnalysis<TClass> :
        ClassPropertyCollectionWithCodeAnalysis
        where TClass : class, IHasNode<ClassDeclarationSyntax>
    {
        private readonly InternalClassTypeWithCodeAnalysis<TClass> classType;
        private readonly ClassPropertyListWrapper<TClass, ClassAutoPropertyWithCodeAnalysis> autoProperties;
        private readonly ClassPropertyListWrapper<TClass, ClassLambdaPropertyWithCodeAnalysis> lambdaProperties;
        private readonly ClassPropertyListWrapper<TClass, ExplicitInterfacePropertyWithCodeAnalysis> explicitInterfaceProperties;
        private readonly ClassPropertyListWrapper<TClass, ClassPropertyWithCodeAnalysis> properties;

        internal InternalClassPropertyCollectionWithCodeAnalysis(InternalClassTypeWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            autoProperties = new ClassPropertyListWrapper<TClass, ClassAutoPropertyWithCodeAnalysis>(
                classType.InternalNode,
                () => new ClassAutoPropertyWithCodeAnalysis(),
                syntax => syntax.IsAutoProperty());
            explicitInterfaceProperties = new ClassPropertyListWrapper<TClass, ExplicitInterfacePropertyWithCodeAnalysis>(
                classType.InternalNode,
                () => new ExplicitInterfacePropertyWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier != null);
            lambdaProperties = new ClassPropertyListWrapper<TClass, ClassLambdaPropertyWithCodeAnalysis>(
                classType.InternalNode,
                () => new ClassLambdaPropertyWithCodeAnalysis(),
                syntax => syntax.IsLambdaProperty());
            properties = new ClassPropertyListWrapper<TClass, ClassPropertyWithCodeAnalysis>(
                classType.InternalNode,
                () => new ClassPropertyWithCodeAnalysis(),
                syntax => syntax.IsProperty());
        }

        public override ICollection<ExplicitInterfacePropertyWithCodeAnalysis> ExplicitInterfaceProperties
        {
            get { return explicitInterfaceProperties; }
            set { classType.Members.CombineList(nameof(ExplicitInterfaceProperties), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ClassPropertyWithCodeAnalysis> Properties
        {
            get { return properties; }
            set { classType.Members.CombineList(nameof(Properties), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ClassAutoPropertyWithCodeAnalysis> AutoProperties
        {
            get { return autoProperties; }
            set { classType.Members.CombineList(nameof(AutoProperties), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ClassLambdaPropertyWithCodeAnalysis> LambdaProperties
        {
            get { return lambdaProperties; }
            set { classType.Members.CombineList(nameof(LambdaProperties), value.Select(item => item.Syntax)); }
        }
    }
}
