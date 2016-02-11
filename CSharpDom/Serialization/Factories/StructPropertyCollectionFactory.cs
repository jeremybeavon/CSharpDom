using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class StructPropertyCollectionFactory :
        AbstractFactory<IStructPropertyCollection, StructPropertyCollection>
    {
        public StructPropertyCollectionFactory(IStructPropertyCollection propertyCollection)
            : base(propertyCollection)
        {
        }

        public override void VisitStructPropertyCollection<TProperty, TExplicitInterfaceProperty>(
            IStructPropertyCollection<TProperty, TExplicitInterfaceProperty> propertyCollection)
        {
            Value = new StructPropertyCollection()
            {
                Properties = propertyCollection.ToList(property => new StructPropertyFactory(property).Value),
                ExplicitInterfaceProperties = propertyCollection.ExplicitInterfaceProperties.ToList(property => new ExplicitInterfacePropertyFactory(property).Value)
            };
        }
    }
}
