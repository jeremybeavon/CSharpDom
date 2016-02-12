using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassPropertyCollection :
        AbstractClassPropertyCollection<ReadOnlyClassProperty, ReadOnlyExplicitInterfaceProperty>
    {
        private readonly IReadOnlyCollection<ReadOnlyClassProperty> properties;
        private readonly IReadOnlyCollection<ReadOnlyExplicitInterfaceProperty> explicitInterfaceProperties;

        public ReadOnlyClassPropertyCollection(ClassBody body)
        {
            properties = body.Properties.ToArray(property => new ReadOnlyClassProperty(property));
            explicitInterfaceProperties = body.ExplicitInterfaceProperties.ToArray(property => new ReadOnlyExplicitInterfaceProperty(property));
        }

        public override IReadOnlyCollection<ReadOnlyExplicitInterfaceProperty> ExplicitInterfaceProperties
        {
            get { return explicitInterfaceProperties; }
        }

        protected override IReadOnlyCollection<ReadOnlyClassProperty> Properties
        {
            get { return properties; }
        }
    }
}
