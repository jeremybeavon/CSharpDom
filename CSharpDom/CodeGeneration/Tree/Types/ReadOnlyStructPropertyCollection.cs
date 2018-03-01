using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStructPropertyCollection :
        AbstractStructPropertyCollection<
            ReadOnlyStructProperty,
            ReadOnlyStructAutoProperty,
            ReadOnlyStructLambdaProperty,
            ReadOnlyExplicitInterfaceProperty>
    {
        private readonly IReadOnlyCollection<ReadOnlyStructProperty> properties;
        private readonly IReadOnlyCollection<ReadOnlyStructAutoProperty> autoProperties;
        private readonly IReadOnlyCollection<ReadOnlyStructLambdaProperty> lambdaProperties;
        private readonly IReadOnlyCollection<ReadOnlyExplicitInterfaceProperty> explicitInterfaceProperties;

        public ReadOnlyStructPropertyCollection(StructBody body)
        {
            properties = body.Properties.ToArray(property => new ReadOnlyStructProperty(property));
            autoProperties = body.AutoProperties.ToArray(property => new ReadOnlyStructAutoProperty(property));
            lambdaProperties = body.LambdaProperties.ToArray(property => new ReadOnlyStructLambdaProperty(property));
            explicitInterfaceProperties = body.ExplicitInterfaceProperties.ToArray(property => new ReadOnlyExplicitInterfaceProperty(property));
        }

        public override IReadOnlyCollection<ReadOnlyExplicitInterfaceProperty> ExplicitInterfaceProperties
        {
            get { return explicitInterfaceProperties; }
        }

        public override IReadOnlyCollection<ReadOnlyStructAutoProperty> AutoProperties => autoProperties;

        public override IReadOnlyCollection<ReadOnlyStructLambdaProperty> LambdaProperties => lambdaProperties;

        protected override IReadOnlyCollection<ReadOnlyStructProperty> Properties
        {
            get { return properties; }
        }
    }
}
