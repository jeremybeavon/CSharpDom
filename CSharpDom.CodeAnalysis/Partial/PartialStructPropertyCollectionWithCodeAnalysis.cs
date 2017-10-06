using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialStructPropertyCollectionWithCodeAnalysis :
        EditableStructPropertyCollection<
            PartialStructPropertyWithCodeAnalysis,
            ExplicitInterfacePropertyWithCodeAnalysis>
    {
        private readonly StructPropertyCollectionWithCodeAnalysis propertyCollection;
        private readonly WrappedCollection<
            StructPropertyWithCodeAnalysis,
            PartialStructPropertyWithCodeAnalysis> properties;
        
        internal PartialStructPropertyCollectionWithCodeAnalysis(
            StructPropertyCollectionWithCodeAnalysis propertyCollection)
        {
            this.propertyCollection = propertyCollection;
            properties = new WrappedCollection<StructPropertyWithCodeAnalysis, PartialStructPropertyWithCodeAnalysis>(
                propertyCollection.Properties,
                parent => new PartialStructPropertyWithCodeAnalysis(parent),
                child => child.Property,
                value => propertyCollection.Properties = value);
        }
        
        public override ICollection<ExplicitInterfacePropertyWithCodeAnalysis> ExplicitInterfaceProperties
        {
            get { return propertyCollection.ExplicitInterfaceProperties; }
            set { propertyCollection.ExplicitInterfaceProperties = value; }
        }

        public override ICollection<PartialStructPropertyWithCodeAnalysis> Properties
        {
            get { return properties; }
            set { properties.Replace(value); }
        }
    }
}
