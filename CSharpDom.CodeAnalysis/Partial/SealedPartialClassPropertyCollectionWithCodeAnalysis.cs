using System.Collections.Generic;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class SealedPartialClassPropertyCollectionWithCodeAnalysis :
        EditableSealedClassPropertyCollection<
            SealedPartialClassPropertyWithCodeAnalysis,
            ExplicitInterfacePropertyWithCodeAnalysis>
    {
        private readonly SealedClassPropertyCollectionWithCodeAnalysis propertyCollection;
        private readonly WrappedCollection<
            SealedClassPropertyWithCodeAnalysis,
            SealedPartialClassPropertyWithCodeAnalysis> properties;
        
        internal SealedPartialClassPropertyCollectionWithCodeAnalysis(
            SealedClassPropertyCollectionWithCodeAnalysis propertyCollection)
        {
            this.propertyCollection = propertyCollection;
            properties = new WrappedCollection<SealedClassPropertyWithCodeAnalysis, SealedPartialClassPropertyWithCodeAnalysis>(
                propertyCollection.Properties,
                parent => new SealedPartialClassPropertyWithCodeAnalysis(parent),
                child => child.InternalProperty,
                value => propertyCollection.Properties = value);
        }
        
        public override ICollection<ExplicitInterfacePropertyWithCodeAnalysis> ExplicitInterfaceProperties
        {
            get { return propertyCollection.ExplicitInterfaceProperties; }
            set { propertyCollection.ExplicitInterfaceProperties = value; }
        }

        public override ICollection<SealedPartialClassPropertyWithCodeAnalysis> Properties
        {
            get { return properties; }
            set { properties.Replace(value); }
        }
    }
}
