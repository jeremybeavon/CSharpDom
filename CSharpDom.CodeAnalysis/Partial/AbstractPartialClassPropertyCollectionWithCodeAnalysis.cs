using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class AbstractPartialClassPropertyCollectionWithCodeAnalysis :
        EditableAbstractClassPropertyCollection<
            AbstractPartialClassPropertyWithCodeAnalysis,
            AbstractPartialClassAutoPropertyWithCodeAnalysis,
            AbstractPartialClassLambdaPropertyWithCodeAnalysis,
            AbstractPartialClassAbstractPropertyWithCodeAnalysis,
            ExplicitInterfacePropertyWithCodeAnalysis>
    {
        private readonly AbstractClassPropertyCollectionWithCodeAnalysis propertyCollection;
        private readonly WrappedCollection<
            AbstractClassAutoPropertyWithCodeAnalysis,
            AbstractPartialClassAutoPropertyWithCodeAnalysis> autoProperties;
        private readonly WrappedCollection<
            AbstractClassLambdaPropertyWithCodeAnalysis,
            AbstractPartialClassLambdaPropertyWithCodeAnalysis> lambdaProperties;
        private readonly WrappedCollection<
            AbstractClassPropertyWithCodeAnalysis,
            AbstractPartialClassPropertyWithCodeAnalysis> properties;
        private readonly WrappedCollection<
            AbstractPropertyWithCodeAnalysis,
            AbstractPartialClassAbstractPropertyWithCodeAnalysis> abstractProperties;

        internal AbstractPartialClassPropertyCollectionWithCodeAnalysis(
            AbstractClassPropertyCollectionWithCodeAnalysis propertyCollection)
        {
            this.propertyCollection = propertyCollection;
            autoProperties = new WrappedCollection<AbstractClassAutoPropertyWithCodeAnalysis, AbstractPartialClassAutoPropertyWithCodeAnalysis>(
                propertyCollection.AutoProperties,
                parent => new AbstractPartialClassAutoPropertyWithCodeAnalysis(parent),
                child => child.Property,
                value => propertyCollection.AutoProperties = value);
            lambdaProperties = new WrappedCollection<AbstractClassLambdaPropertyWithCodeAnalysis, AbstractPartialClassLambdaPropertyWithCodeAnalysis>(
                propertyCollection.LambdaProperties,
                parent => new AbstractPartialClassLambdaPropertyWithCodeAnalysis(parent),
                child => child.Property,
                value => propertyCollection.LambdaProperties = value);
            properties = new WrappedCollection<AbstractClassPropertyWithCodeAnalysis, AbstractPartialClassPropertyWithCodeAnalysis>(
                propertyCollection.Properties,
                parent => new AbstractPartialClassPropertyWithCodeAnalysis(parent),
                child => child.Property,
                value => propertyCollection.Properties = value);
            abstractProperties = new WrappedCollection<AbstractPropertyWithCodeAnalysis, AbstractPartialClassAbstractPropertyWithCodeAnalysis>(
                propertyCollection.AbstractProperties,
                parent => new AbstractPartialClassAbstractPropertyWithCodeAnalysis(parent),
                child => child.Property,
                value => propertyCollection.AbstractProperties = value);
        }

        public override ICollection<AbstractPartialClassAbstractPropertyWithCodeAnalysis> AbstractProperties
        {
            get { return abstractProperties; }
            set { abstractProperties.Replace(value); }
        }

        public override ICollection<AbstractPartialClassAutoPropertyWithCodeAnalysis> AutoProperties
        {
            get => autoProperties;
            set => autoProperties.Replace(value);
        }

        public override ICollection<ExplicitInterfacePropertyWithCodeAnalysis> ExplicitInterfaceProperties
        {
            get { return propertyCollection.ExplicitInterfaceProperties; }
            set { propertyCollection.ExplicitInterfaceProperties = value; }
        }

        public override ICollection<AbstractPartialClassLambdaPropertyWithCodeAnalysis> LambdaProperties
        {
            get => lambdaProperties;
            set => lambdaProperties.Replace(value);
        }

        public override ICollection<AbstractPartialClassPropertyWithCodeAnalysis> Properties
        {
            get { return properties; }
            set { properties.Replace(value); }
        }
    }
}
