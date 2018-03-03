using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalStaticClassPropertyCollectionWithCodeAnalysis<TClass> :
        StaticClassPropertyCollectionWithCodeAnalysis
        where TClass : class, IHasNode<ClassDeclarationSyntax>
    {
        private readonly InternalStaticTypeWithCodeAnalysis<TClass> classType;
        private readonly ClassPropertyListWrapper<TClass, StaticClassPropertyWithCodeAnalysis> properties;
        private readonly ClassPropertyListWrapper<TClass, StaticClassAutoPropertyWithCodeAnalysis> autoProperties;
        private readonly ClassPropertyListWrapper<TClass, StaticClassLambdaPropertyWithCodeAnalysis> lambdaProperties;

        internal InternalStaticClassPropertyCollectionWithCodeAnalysis(InternalStaticTypeWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            properties = new ClassPropertyListWrapper<TClass, StaticClassPropertyWithCodeAnalysis>(
                classType.InternalNode,
                () => new StaticClassPropertyWithCodeAnalysis(),
                syntax => syntax.IsProperty());
            autoProperties = new ClassPropertyListWrapper<TClass, StaticClassAutoPropertyWithCodeAnalysis>(
                classType.InternalNode,
                () => new StaticClassAutoPropertyWithCodeAnalysis(),
                syntax => syntax.IsAutoProperty());
            lambdaProperties = new ClassPropertyListWrapper<TClass, StaticClassLambdaPropertyWithCodeAnalysis>(
                classType.InternalNode,
                () => new StaticClassLambdaPropertyWithCodeAnalysis(),
                syntax => syntax.IsLambdaProperty());
        }
        
        protected override ICollection<StaticClassPropertyWithCodeAnalysis> Properties
        {
            get { return properties; }
            set { classType.Members.CombineList(nameof(Properties), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StaticClassAutoPropertyWithCodeAnalysis> AutoProperties
        {
            get { return autoProperties; }
            set { classType.Members.CombineList(nameof(AutoProperties), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StaticClassLambdaPropertyWithCodeAnalysis> LambdaProperties
        {
            get { return lambdaProperties; }
            set { classType.Members.CombineList(nameof(LambdaProperties), value.Select(item => item.Syntax)); }
        }
    }
}
