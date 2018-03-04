using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialStructPropertyCollectionWithCodeAnalysis :
        EditableStructPropertyCollection<
            PartialStructPropertyWithCodeAnalysis,
            PartialStructAutoPropertyWithCodeAnalysis,
            PartialStructLambdaPropertyWithCodeAnalysis,
            ExplicitInterfacePropertyWithCodeAnalysis>
    {
        private readonly StructPropertyCollectionWithCodeAnalysis propertyCollection;
        private readonly WrappedCollection<
            StructAutoPropertyWithCodeAnalysis,
            PartialStructAutoPropertyWithCodeAnalysis> autoProperties;
        private readonly WrappedCollection<
            StructLambdaPropertyWithCodeAnalysis,
            PartialStructLambdaPropertyWithCodeAnalysis> lambdaProperties;
        private readonly WrappedCollection<
            StructPropertyWithCodeAnalysis,
            PartialStructPropertyWithCodeAnalysis> properties;
        
        internal PartialStructPropertyCollectionWithCodeAnalysis(
            StructPropertyCollectionWithCodeAnalysis propertyCollection)
        {
            this.propertyCollection = propertyCollection;
            autoProperties = new WrappedCollection<StructAutoPropertyWithCodeAnalysis, PartialStructAutoPropertyWithCodeAnalysis>(
                propertyCollection.AutoProperties,
                parent => new PartialStructAutoPropertyWithCodeAnalysis(parent),
                child => child.Property,
                value => propertyCollection.AutoProperties = value);
            lambdaProperties = new WrappedCollection<StructLambdaPropertyWithCodeAnalysis, PartialStructLambdaPropertyWithCodeAnalysis>(
                propertyCollection.LambdaProperties,
                parent => new PartialStructLambdaPropertyWithCodeAnalysis(parent),
                child => child.Property,
                value => propertyCollection.LambdaProperties = value);
            properties = new WrappedCollection<StructPropertyWithCodeAnalysis, PartialStructPropertyWithCodeAnalysis>(
                propertyCollection.Properties,
                parent => new PartialStructPropertyWithCodeAnalysis(parent),
                child => child.Property,
                value => propertyCollection.Properties = value);
        }

        public override ICollection<PartialStructAutoPropertyWithCodeAnalysis> AutoProperties
        {
            get => autoProperties;
            set => autoProperties.Replace(value);
        }

        public override ICollection<ExplicitInterfacePropertyWithCodeAnalysis> ExplicitInterfaceProperties
        {
            get { return propertyCollection.ExplicitInterfaceProperties; }
            set { propertyCollection.ExplicitInterfaceProperties = value; }
        }

        public override ICollection<PartialStructLambdaPropertyWithCodeAnalysis> LambdaProperties
        {
            get => lambdaProperties;
            set => lambdaProperties.Replace(value);
        }

        public override ICollection<PartialStructPropertyWithCodeAnalysis> Properties
        {
            get { return properties; }
            set { properties.Replace(value); }
        }
    }
}
