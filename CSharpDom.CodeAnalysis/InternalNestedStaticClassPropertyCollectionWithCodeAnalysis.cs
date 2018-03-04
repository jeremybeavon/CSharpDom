using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalNestedStaticClassPropertyCollectionWithCodeAnalysis<TClass> :
        NestedStaticClassPropertyCollectionWithCodeAnalysis
        where TClass : class, IHasNode<ClassDeclarationSyntax>
    {
        private readonly InternalNestedStaticClassWithCodeAnalysis<TClass> classType;
        private readonly ClassPropertyListWrapper<TClass, NestedStaticClassPropertyWithCodeAnalysis> properties;
        private readonly ClassPropertyListWrapper<TClass, NestedStaticClassAutoPropertyWithCodeAnalysis> autoProperties;
        private readonly ClassPropertyListWrapper<TClass, NestedStaticClassLambdaPropertyWithCodeAnalysis> lambdaProperties;

        internal InternalNestedStaticClassPropertyCollectionWithCodeAnalysis(
            InternalNestedStaticClassWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            properties = new ClassPropertyListWrapper<TClass, NestedStaticClassPropertyWithCodeAnalysis>(
                classType.InternalNode,
                () => new NestedStaticClassPropertyWithCodeAnalysis(),
                syntax => syntax.IsProperty());
            autoProperties = new ClassPropertyListWrapper<TClass, NestedStaticClassAutoPropertyWithCodeAnalysis>(
                classType.InternalNode,
                () => new NestedStaticClassAutoPropertyWithCodeAnalysis(),
                syntax => syntax.IsAutoProperty());
            lambdaProperties = new ClassPropertyListWrapper<TClass, NestedStaticClassLambdaPropertyWithCodeAnalysis>(
                classType.InternalNode,
                () => new NestedStaticClassLambdaPropertyWithCodeAnalysis(),
                syntax => syntax.IsLambdaProperty());
        }
        
        public override ICollection<NestedStaticClassPropertyWithCodeAnalysis> Properties
        {
            get { return properties; }
            set { classType.Members.CombineList(nameof(Properties), value.Select(item => item.Syntax)); }
        }

        public override ICollection<NestedStaticClassAutoPropertyWithCodeAnalysis> AutoProperties
        {
            get { return autoProperties; }
            set { classType.Members.CombineList(nameof(AutoProperties), value.Select(item => item.Syntax)); }
        }

        public override ICollection<NestedStaticClassLambdaPropertyWithCodeAnalysis> LambdaProperties
        {
            get { return lambdaProperties; }
            set { classType.Members.CombineList(nameof(LambdaProperties), value.Select(item => item.Syntax)); }
        }
    }
}
