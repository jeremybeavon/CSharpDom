using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialClassPropertyCollectionWithCodeAnalysis :
        EditableClassPropertyCollection<
            PartialClassPropertyWithCodeAnalysis,
            PartialClassAutoPropertyWithCodeAnalysis,
            PartialClassLambdaPropertyWithCodeAnalysis,
            ExplicitInterfacePropertyWithCodeAnalysis>
    {
        private readonly ClassPropertyCollectionWithCodeAnalysis propertyCollection;
        private readonly WrappedCollection<
            ClassAutoPropertyWithCodeAnalysis,
            PartialClassAutoPropertyWithCodeAnalysis> autoProperties;
        private readonly WrappedCollection<
            ClassLambdaPropertyWithCodeAnalysis,
            PartialClassLambdaPropertyWithCodeAnalysis> lambdaProperties;
        private readonly WrappedCollection<
            ClassPropertyWithCodeAnalysis,
            PartialClassPropertyWithCodeAnalysis> properties;
        
        internal PartialClassPropertyCollectionWithCodeAnalysis(
            ClassPropertyCollectionWithCodeAnalysis propertyCollection)
        {
            this.propertyCollection = propertyCollection;
            autoProperties = new WrappedCollection<ClassAutoPropertyWithCodeAnalysis, PartialClassAutoPropertyWithCodeAnalysis>(
                propertyCollection.AutoProperties,
                parent => new PartialClassAutoPropertyWithCodeAnalysis(parent),
                child => child.Property,
                value => propertyCollection.AutoProperties = value);
            lambdaProperties = new WrappedCollection<ClassLambdaPropertyWithCodeAnalysis, PartialClassLambdaPropertyWithCodeAnalysis>(
                propertyCollection.LambdaProperties,
                parent => new PartialClassLambdaPropertyWithCodeAnalysis(parent),
                child => child.Property,
                value => propertyCollection.LambdaProperties = value);
            properties = new WrappedCollection<ClassPropertyWithCodeAnalysis, PartialClassPropertyWithCodeAnalysis>(
                propertyCollection.Properties,
                parent => new PartialClassPropertyWithCodeAnalysis(parent),
                child => child.Property,
                value => propertyCollection.Properties = value);
        }

        public override ICollection<PartialClassAutoPropertyWithCodeAnalysis> AutoProperties
        {
            get => autoProperties;
            set => autoProperties.Replace(value);
        }

        public override ICollection<ExplicitInterfacePropertyWithCodeAnalysis> ExplicitInterfaceProperties
        {
            get { return propertyCollection.ExplicitInterfaceProperties; }
            set { propertyCollection.ExplicitInterfaceProperties = value; }
        }

        public override ICollection<PartialClassLambdaPropertyWithCodeAnalysis> LambdaProperties
        {
            get => lambdaProperties;
            set => lambdaProperties.Replace(value);
        }

        public override ICollection<PartialClassPropertyWithCodeAnalysis> Properties
        {
            get { return properties; }
            set { properties.Replace(value); }
        }
    }
}
