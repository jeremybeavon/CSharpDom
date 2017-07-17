using System.Collections.Generic;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialClassPropertyCollectionWithCodeAnalysis :
        EditableClassPropertyCollection<
            PartialClassPropertyWithCodeAnalysis,
            ExplicitInterfacePropertyWithCodeAnalysis>
    {
        private readonly ClassPropertyCollectionWithCodeAnalysis propertyCollection;
        private readonly WrappedCollection<
            ClassPropertyWithCodeAnalysis,
            PartialClassPropertyWithCodeAnalysis> properties;
        
        internal PartialClassPropertyCollectionWithCodeAnalysis(
            ClassPropertyCollectionWithCodeAnalysis propertyCollection)
        {
            this.propertyCollection = propertyCollection;
            properties = new WrappedCollection<ClassPropertyWithCodeAnalysis, PartialClassPropertyWithCodeAnalysis>(
                propertyCollection.Properties,
                parent => new PartialClassPropertyWithCodeAnalysis(parent),
                child => child.InternalProperty,
                value => propertyCollection.Properties = value);
        }
        
        public override ICollection<ExplicitInterfacePropertyWithCodeAnalysis> ExplicitInterfaceProperties
        {
            get { return propertyCollection.ExplicitInterfaceProperties; }
            set { propertyCollection.ExplicitInterfaceProperties = value; }
        }

        public override ICollection<PartialClassPropertyWithCodeAnalysis> Properties
        {
            get { return properties; }
            set { properties.Replace(value); }
        }
    }
}
