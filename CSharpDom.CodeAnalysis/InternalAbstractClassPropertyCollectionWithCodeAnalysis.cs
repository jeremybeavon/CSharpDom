using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalAbstractClassPropertyCollectionWithCodeAnalysis<TClass> :
        AbstractClassPropertyCollectionWithCodeAnalysis
        where TClass : class, IHasNode<ClassDeclarationSyntax>
    {
        private readonly InternalClassTypeWithCodeAnalysis<TClass> classType;
        private readonly ClassPropertyListWrapper<TClass, AbstractClassPropertyWithCodeAnalysis> properties;
        private readonly ClassPropertyListWrapper<TClass, AbstractClassAutoPropertyWithCodeAnalysis> autoProperties;
        private readonly ClassPropertyListWrapper<TClass, AbstractClassLambdaPropertyWithCodeAnalysis> lambdaProperties;
        private readonly ClassPropertyListWrapper<TClass, AbstractPropertyWithCodeAnalysis> abstractProperties;

        internal InternalAbstractClassPropertyCollectionWithCodeAnalysis(
            InternalClassTypeWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            properties = new ClassPropertyListWrapper<TClass, AbstractClassPropertyWithCodeAnalysis>(
                classType.InternalNode,
                () => new AbstractClassPropertyWithCodeAnalysis(),
                syntax => syntax.IsProperty());
            autoProperties = new ClassPropertyListWrapper<TClass, AbstractClassAutoPropertyWithCodeAnalysis>(
                classType.InternalNode,
                () => new AbstractClassAutoPropertyWithCodeAnalysis(),
                syntax => syntax.IsAutoProperty() && !syntax.Modifiers.IsAbstract());
            lambdaProperties = new ClassPropertyListWrapper<TClass, AbstractClassLambdaPropertyWithCodeAnalysis>(
                classType.InternalNode,
                () => new AbstractClassLambdaPropertyWithCodeAnalysis(),
                syntax => syntax.IsLambdaProperty());
            abstractProperties = new ClassPropertyListWrapper<TClass, AbstractPropertyWithCodeAnalysis>(
                classType.InternalNode,
                () => new AbstractPropertyWithCodeAnalysis(),
                syntax => syntax.Modifiers.IsAbstract());

        }

        public override ICollection<AbstractPropertyWithCodeAnalysis> AbstractProperties
        {
            get { return abstractProperties; }
            set { classType.Members.CombineList(nameof(AbstractProperties), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ExplicitInterfacePropertyWithCodeAnalysis> ExplicitInterfaceProperties
        {
            get { return classType.Properties.ExplicitInterfaceProperties; }
            set { classType.Properties.ExplicitInterfaceProperties = value; }
        }

        public override ICollection<AbstractClassPropertyWithCodeAnalysis> Properties
        {
            get { return properties; }
            set { classType.Members.CombineList(nameof(Properties), value.Select(item => item.Syntax)); }
        }

        public override ICollection<AbstractClassAutoPropertyWithCodeAnalysis> AutoProperties
        {
            get { return autoProperties; }
            set { classType.Members.CombineList(nameof(AutoProperties), value.Select(item => item.Syntax)); }
        }

        public override ICollection<AbstractClassLambdaPropertyWithCodeAnalysis> LambdaProperties
        {
            get { return lambdaProperties; }
            set { classType.Members.CombineList(nameof(LambdaProperties), value.Select(item => item.Syntax)); }
        }
    }
}
