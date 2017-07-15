using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalAbstractClassPropertyCollectionWithCodeAnalysis<TClass> :
        AbstractClassPropertyCollectionWithCodeAnalysis
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalClassTypeWithCodeAnalysis<TClass> classType;
        private readonly ClassPropertyListWrapper<TClass, AbstractClassPropertyWithCodeAnalysis> properties;
        private readonly ClassPropertyListWrapper<TClass, AbstractPropertyWithCodeAnalysis> abstractProperties;

        internal InternalAbstractClassPropertyCollectionWithCodeAnalysis(InternalClassTypeWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            properties = new ClassPropertyListWrapper<TClass, AbstractClassPropertyWithCodeAnalysis>(
                classType.Node,
                () => new AbstractClassPropertyWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier == null && !syntax.Modifiers.IsAbstract());
            abstractProperties = new ClassPropertyListWrapper<TClass, AbstractPropertyWithCodeAnalysis>(
                classType.Node,
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
    }
}
