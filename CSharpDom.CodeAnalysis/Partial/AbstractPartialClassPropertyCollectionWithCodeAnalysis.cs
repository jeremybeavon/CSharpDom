using System.Collections.Generic;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class AbstractPartialClassPropertyCollectionWithCodeAnalysis :
        EditableAbstractClassPropertyCollection<
            AbstractPartialClassPropertyWithCodeAnalysis,
            AbstractPartialClassAbstractPropertyWithCodeAnalysis,
            ExplicitInterfacePropertyWithCodeAnalysis>
    {
        private readonly AbstractClassPropertyCollectionWithCodeAnalysis propertyCollection;
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
            properties = new WrappedCollection<AbstractClassPropertyWithCodeAnalysis, AbstractPartialClassPropertyWithCodeAnalysis>(
                propertyCollection.Properties,
                parent => new AbstractPartialClassPropertyWithCodeAnalysis(parent),
                child => child.InternalProperty,
                value => propertyCollection.Properties = value);
            abstractProperties = new WrappedCollection<AbstractPropertyWithCodeAnalysis, AbstractPartialClassAbstractPropertyWithCodeAnalysis>(
                propertyCollection.AbstractProperties,
                parent => new AbstractPartialClassAbstractPropertyWithCodeAnalysis(parent),
                child => child.InternalProperty,
                value => propertyCollection.AbstractProperties = value);
        }

        public override ICollection<AbstractPartialClassAbstractPropertyWithCodeAnalysis> AbstractProperties
        {
            get { return abstractProperties; }
            set { abstractProperties.Replace(value); }
        }

        public override ICollection<ExplicitInterfacePropertyWithCodeAnalysis> ExplicitInterfaceProperties
        {
            get { return propertyCollection.ExplicitInterfaceProperties; }
            set { propertyCollection.ExplicitInterfaceProperties = value; }
        }

        public override ICollection<AbstractPartialClassPropertyWithCodeAnalysis> Properties
        {
            get { return properties; }
            set { properties.Replace(value); }
        }
    }
}
