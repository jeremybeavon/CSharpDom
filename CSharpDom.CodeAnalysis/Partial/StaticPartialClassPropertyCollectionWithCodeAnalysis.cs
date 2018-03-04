using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StaticPartialClassPropertyCollectionWithCodeAnalysis :
        EditableStaticClassPropertyCollection<
            StaticPartialClassPropertyWithCodeAnalysis,
            StaticPartialClassAutoPropertyWithCodeAnalysis,
            StaticPartialClassLambdaPropertyWithCodeAnalysis>
    {
        private readonly StaticClassPropertyCollectionWithCodeAnalysis propertyCollection;
        private readonly WrappedCollection<
            StaticClassAutoPropertyWithCodeAnalysis,
            StaticPartialClassAutoPropertyWithCodeAnalysis> autoProperties;
        private readonly WrappedCollection<
            StaticClassLambdaPropertyWithCodeAnalysis,
            StaticPartialClassLambdaPropertyWithCodeAnalysis> lambdaProperties;
        private readonly WrappedCollection<
            StaticClassPropertyWithCodeAnalysis,
            StaticPartialClassPropertyWithCodeAnalysis> properties;
        
        internal StaticPartialClassPropertyCollectionWithCodeAnalysis(
            StaticClassPropertyCollectionWithCodeAnalysis propertyCollection)
        {
            this.propertyCollection = propertyCollection;
            autoProperties = new WrappedCollection<StaticClassAutoPropertyWithCodeAnalysis, StaticPartialClassAutoPropertyWithCodeAnalysis>(
                propertyCollection.AutoProperties,
                parent => new StaticPartialClassAutoPropertyWithCodeAnalysis(parent),
                child => child.Property,
                value => propertyCollection.AutoProperties = value);
            lambdaProperties = new WrappedCollection<StaticClassLambdaPropertyWithCodeAnalysis, StaticPartialClassLambdaPropertyWithCodeAnalysis>(
                propertyCollection.LambdaProperties,
                parent => new StaticPartialClassLambdaPropertyWithCodeAnalysis(parent),
                child => child.Property,
                value => propertyCollection.LambdaProperties = value);
            properties = new WrappedCollection<StaticClassPropertyWithCodeAnalysis, StaticPartialClassPropertyWithCodeAnalysis>(
                propertyCollection.Properties,
                parent => new StaticPartialClassPropertyWithCodeAnalysis(parent),
                child => child.Property,
                value => propertyCollection.Properties = value);
        }

        public override ICollection<StaticPartialClassAutoPropertyWithCodeAnalysis> AutoProperties
        {
            get => autoProperties;
            set => autoProperties.Replace(value);
        }
        
        public override ICollection<StaticPartialClassLambdaPropertyWithCodeAnalysis> LambdaProperties
        {
            get => lambdaProperties;
            set => lambdaProperties.Replace(value);
        }

        public override ICollection<StaticPartialClassPropertyWithCodeAnalysis> Properties
        {
            get { return properties; }
            set { properties.Replace(value); }
        }
    }
}
