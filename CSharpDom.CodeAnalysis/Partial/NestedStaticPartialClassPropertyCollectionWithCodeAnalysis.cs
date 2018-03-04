using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class NestedStaticPartialClassPropertyCollectionWithCodeAnalysis :
        EditableStaticClassPropertyCollection<
            NestedStaticPartialClassPropertyWithCodeAnalysis,
            NestedStaticPartialClassAutoPropertyWithCodeAnalysis,
            NestedStaticPartialClassLambdaPropertyWithCodeAnalysis>
    {
        private readonly NestedStaticClassPropertyCollectionWithCodeAnalysis propertyCollection;
        private readonly WrappedCollection<
            NestedStaticClassAutoPropertyWithCodeAnalysis,
            NestedStaticPartialClassAutoPropertyWithCodeAnalysis> autoProperties;
        private readonly WrappedCollection<
            NestedStaticClassLambdaPropertyWithCodeAnalysis,
            NestedStaticPartialClassLambdaPropertyWithCodeAnalysis> lambdaProperties;
        private readonly WrappedCollection<
            NestedStaticClassPropertyWithCodeAnalysis,
            NestedStaticPartialClassPropertyWithCodeAnalysis> properties;
        
        internal NestedStaticPartialClassPropertyCollectionWithCodeAnalysis(
            NestedStaticClassPropertyCollectionWithCodeAnalysis propertyCollection)
        {
            this.propertyCollection = propertyCollection;
            autoProperties = new WrappedCollection<NestedStaticClassAutoPropertyWithCodeAnalysis, NestedStaticPartialClassAutoPropertyWithCodeAnalysis>(
                propertyCollection.AutoProperties,
                parent => new NestedStaticPartialClassAutoPropertyWithCodeAnalysis(parent),
                child => child.Property,
                value => propertyCollection.AutoProperties = value);
            lambdaProperties = new WrappedCollection<NestedStaticClassLambdaPropertyWithCodeAnalysis, NestedStaticPartialClassLambdaPropertyWithCodeAnalysis>(
                propertyCollection.LambdaProperties,
                parent => new NestedStaticPartialClassLambdaPropertyWithCodeAnalysis(parent),
                child => child.Property,
                value => propertyCollection.LambdaProperties = value);
            properties = new WrappedCollection<NestedStaticClassPropertyWithCodeAnalysis, NestedStaticPartialClassPropertyWithCodeAnalysis>(
                propertyCollection.Properties,
                parent => new NestedStaticPartialClassPropertyWithCodeAnalysis(parent),
                child => child.Property,
                value => propertyCollection.Properties = value);
        }

        public override ICollection<NestedStaticPartialClassAutoPropertyWithCodeAnalysis> AutoProperties
        {
            get => autoProperties;
            set => autoProperties.Replace(value);
        }
        
        public override ICollection<NestedStaticPartialClassLambdaPropertyWithCodeAnalysis> LambdaProperties
        {
            get => lambdaProperties;
            set => lambdaProperties.Replace(value);
        }

        public override ICollection<NestedStaticPartialClassPropertyWithCodeAnalysis> Properties
        {
            get { return properties; }
            set { properties.Replace(value); }
        }
    }
}
