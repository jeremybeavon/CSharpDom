using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class SealedPartialClassPropertyCollectionWithCodeAnalysis :
        EditableSealedClassPropertyCollection<
            SealedPartialClassPropertyWithCodeAnalysis,
            SealedPartialClassAutoPropertyWithCodeAnalysis,
            SealedPartialClassLambdaPropertyWithCodeAnalysis,
            ExplicitInterfacePropertyWithCodeAnalysis>
    {
        private readonly SealedClassPropertyCollectionWithCodeAnalysis propertyCollection;
        private readonly WrappedCollection<
            SealedClassAutoPropertyWithCodeAnalysis,
            SealedPartialClassAutoPropertyWithCodeAnalysis> autoProperties;
        private readonly WrappedCollection<
            SealedClassLambdaPropertyWithCodeAnalysis,
            SealedPartialClassLambdaPropertyWithCodeAnalysis> lambdaProperties;
        private readonly WrappedCollection<
            SealedClassPropertyWithCodeAnalysis,
            SealedPartialClassPropertyWithCodeAnalysis> properties;
        
        internal SealedPartialClassPropertyCollectionWithCodeAnalysis(
            SealedClassPropertyCollectionWithCodeAnalysis propertyCollection)
        {
            this.propertyCollection = propertyCollection;
            autoProperties = new WrappedCollection<SealedClassAutoPropertyWithCodeAnalysis, SealedPartialClassAutoPropertyWithCodeAnalysis>(
                propertyCollection.AutoProperties,
                parent => new SealedPartialClassAutoPropertyWithCodeAnalysis(parent),
                child => child.Property,
                value => propertyCollection.AutoProperties = value);
            lambdaProperties = new WrappedCollection<SealedClassLambdaPropertyWithCodeAnalysis, SealedPartialClassLambdaPropertyWithCodeAnalysis>(
                propertyCollection.LambdaProperties,
                parent => new SealedPartialClassLambdaPropertyWithCodeAnalysis(parent),
                child => child.Property,
                value => propertyCollection.LambdaProperties = value);
            properties = new WrappedCollection<SealedClassPropertyWithCodeAnalysis, SealedPartialClassPropertyWithCodeAnalysis>(
                propertyCollection.Properties,
                parent => new SealedPartialClassPropertyWithCodeAnalysis(parent),
                child => child.Property,
                value => propertyCollection.Properties = value);
        }

        public override ICollection<SealedPartialClassAutoPropertyWithCodeAnalysis> AutoProperties
        {
            get => autoProperties;
            set => autoProperties.Replace(value);
        }

        public override ICollection<ExplicitInterfacePropertyWithCodeAnalysis> ExplicitInterfaceProperties
        {
            get { return propertyCollection.ExplicitInterfaceProperties; }
            set { propertyCollection.ExplicitInterfaceProperties = value; }
        }

        public override ICollection<SealedPartialClassLambdaPropertyWithCodeAnalysis> LambdaProperties
        {
            get => lambdaProperties;
            set => lambdaProperties.Replace(value);
        }

        public override ICollection<SealedPartialClassPropertyWithCodeAnalysis> Properties
        {
            get { return properties; }
            set { properties.Replace(value); }
        }
    }
}
