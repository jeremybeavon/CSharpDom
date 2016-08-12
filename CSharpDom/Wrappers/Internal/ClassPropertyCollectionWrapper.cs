using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class ClassPropertyCollectionWrapper :
        AbstractWrapper<IClassPropertyCollection>
    {
        public ClassPropertyCollectionWrapper(IClassPropertyCollection propertyCollection)
            : base(propertyCollection)
        {
        }

        public override void VisitClassPropertyCollection<TProperty, TExplicitInterfaceProperty>(
            IClassPropertyCollection<TProperty, TExplicitInterfaceProperty> propertyCollection)
        {
            Value = new ClassPropertyCollection()
            {
                Properties = propertyCollection.ToList(property => new ClassPropertyWrapper(property).Value),
                ExplicitInterfaceProperties = propertyCollection.ExplicitInterfaceProperties.ToList(property => new ExplicitInterfacePropertyWrapper(property).Value)
            };
        }
    }
}
