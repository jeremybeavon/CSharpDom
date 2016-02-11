using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class SealedClassPropertyCollectionFactory :
        AbstractFactory<ISealedClassPropertyCollection, SealedClassPropertyCollection>
    {
        public SealedClassPropertyCollectionFactory(ISealedClassPropertyCollection propertyCollection)
            : base(propertyCollection)
        {
        }

        public override void VisitSealedClassPropertyCollection<TProperty, TProtectedOverrideProperty, TExplicitInterfaceProperty>(
            ISealedClassPropertyCollection<TProperty, TProtectedOverrideProperty, TExplicitInterfaceProperty> propertyCollection)
        {
            Value = new SealedClassPropertyCollection()
            {
                Properties = propertyCollection.ToList(property => new SealedClassPropertyFactory(property).Value),
                ProtectedOverrideProperties = propertyCollection.ProtectedOverrideProperties.ToList(property => new ProtectedOverridePropertyFactory(property).Value),
                ExplicitInterfaceProperties = propertyCollection.ExplicitInterfaceProperties.ToList(property => new ExplicitInterfacePropertyFactory(property).Value)
            };
        }
    }
}
