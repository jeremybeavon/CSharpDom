using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class ClassPropertyCollectionFactory :
        AbstractFactory<IClassPropertyCollection, ClassPropertyCollection>
    {
        public ClassPropertyCollectionFactory(IClassPropertyCollection propertyCollection)
            : base(propertyCollection)
        {
        }

        public override void VisitClassPropertyCollection<TProperty, TExplicitInterfaceProperty>(
            IClassPropertyCollection<TProperty, TExplicitInterfaceProperty> propertyCollection)
        {
            Value = new ClassPropertyCollection()
            {
                Properties = propertyCollection.ToList(property => new ClassPropertyFactory(property).Value),
                ExplicitInterfaceProperties = propertyCollection.ExplicitInterfaceProperties.ToList(property => new ExplicitInterfacePropertyFactory(property).Value)
            };
        }
    }
}
