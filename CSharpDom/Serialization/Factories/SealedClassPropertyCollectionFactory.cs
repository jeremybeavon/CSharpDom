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

        public override void VisitSealedClassPropertyCollection<TProperty, TExplicitInterfaceProperty>(
            ISealedClassPropertyCollection<TProperty, TExplicitInterfaceProperty> propertyCollection)
        {
            Value = new SealedClassPropertyCollection()
            {
                Properties = propertyCollection.ToList(property => new SealedClassPropertyFactory(property).Value),
                ExplicitInterfaceProperties = propertyCollection.ExplicitInterfaceProperties.ToList(property => new ExplicitInterfacePropertyFactory(property).Value)
            };
        }
    }
}
