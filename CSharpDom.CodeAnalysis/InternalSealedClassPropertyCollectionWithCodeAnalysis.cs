using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalSealedClassPropertyCollectionWithCodeAnalysis<TClass> :
        SealedClassPropertyCollectionWithCodeAnalysis
        where TClass : class, IHasNode<ClassDeclarationSyntax>
    {
        private readonly InternalClassTypeWithCodeAnalysis<TClass> classType;
        private readonly ClassPropertyListWrapper<TClass, SealedClassPropertyWithCodeAnalysis> properties;
        private readonly ClassPropertyListWrapper<TClass, SealedClassAutoPropertyWithCodeAnalysis> autoProperties;
        private readonly ClassPropertyListWrapper<TClass, SealedClassLambdaPropertyWithCodeAnalysis> lambdaProperties;

        internal InternalSealedClassPropertyCollectionWithCodeAnalysis(InternalClassTypeWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            properties = new ClassPropertyListWrapper<TClass, SealedClassPropertyWithCodeAnalysis>(
                classType.InternalNode,
                () => new SealedClassPropertyWithCodeAnalysis(),
                syntax => syntax.IsProperty());
            autoProperties = new ClassPropertyListWrapper<TClass, SealedClassAutoPropertyWithCodeAnalysis>(
                classType.InternalNode,
                () => new SealedClassAutoPropertyWithCodeAnalysis(),
                syntax => syntax.IsAutoProperty());
            lambdaProperties = new ClassPropertyListWrapper<TClass, SealedClassLambdaPropertyWithCodeAnalysis>(
                classType.InternalNode,
                () => new SealedClassLambdaPropertyWithCodeAnalysis(),
                syntax => syntax.IsLambdaProperty());
        }
        
        public override ICollection<ExplicitInterfacePropertyWithCodeAnalysis> ExplicitInterfaceProperties
        {
            get { return classType.Properties.ExplicitInterfaceProperties; }
            set { classType.Properties.ExplicitInterfaceProperties = value; }
        }

        public override ICollection<SealedClassPropertyWithCodeAnalysis> Properties
        {
            get { return properties; }
            set { classType.Members.CombineList(nameof(Properties), value.Select(item => item.Syntax)); }
        }

        public override ICollection<SealedClassAutoPropertyWithCodeAnalysis> AutoProperties
        {
            get { return autoProperties; }
            set { classType.Members.CombineList(nameof(AutoProperties), value.Select(item => item.Syntax)); }
        }

        public override ICollection<SealedClassLambdaPropertyWithCodeAnalysis> LambdaProperties
        {
            get { return lambdaProperties; }
            set { classType.Members.CombineList(nameof(LambdaProperties), value.Select(item => item.Syntax)); }
        }
    }
}
