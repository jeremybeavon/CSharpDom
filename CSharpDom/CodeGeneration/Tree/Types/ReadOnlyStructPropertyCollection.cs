using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStructPropertyCollection :
        AbstractStructPropertyCollection<ReadOnlyStructProperty, ReadOnlyExplicitInterfaceProperty>
    {
        private readonly IReadOnlyCollection<ReadOnlyStructProperty> properties;
        private readonly IReadOnlyCollection<ReadOnlyExplicitInterfaceProperty> explicitInterfaceProperties;

        public ReadOnlyStructPropertyCollection(StructBody body)
        {
            properties = body.Properties.ToArray(property => new ReadOnlyStructProperty(property));
            explicitInterfaceProperties = body.ExplicitInterfaceProperties.ToArray(property => new ReadOnlyExplicitInterfaceProperty(property));
        }

        public override IReadOnlyCollection<ReadOnlyExplicitInterfaceProperty> ExplicitInterfaceProperties
        {
            get { return explicitInterfaceProperties; }
        }

        protected override IReadOnlyCollection<ReadOnlyStructProperty> Properties
        {
            get { return properties; }
        }
    }
}
