using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class StructPropertyCollectionWrapper :
        AbstractWrapper<IStructPropertyCollection>
    {
        public StructPropertyCollectionWrapper(IStructPropertyCollection propertyCollection)
            : base(propertyCollection)
        {
        }

        public override void VisitStructPropertyCollection<TProperty, TExplicitInterfaceProperty>(
            IStructPropertyCollection<TProperty, TExplicitInterfaceProperty> propertyCollection)
        {
            Value = new StructPropertyCollection()
            {
                Properties = propertyCollection.ToList(property => new StructPropertyWrapper(property).Value),
                ExplicitInterfaceProperties = propertyCollection.ExplicitInterfaceProperties.ToList(property => new ExplicitInterfacePropertyWrapper(property).Value)
            };
        }
    }
}
