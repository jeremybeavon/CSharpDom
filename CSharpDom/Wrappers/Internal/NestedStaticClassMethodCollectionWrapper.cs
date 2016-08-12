using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class NestedStaticClassMethodCollectionWrapper :
        AbstractWrapper<INestedStaticClassMethodCollection>
    {
        public NestedStaticClassMethodCollectionWrapper(INestedStaticClassMethodCollection methodCollection)
            : base(methodCollection)
        {
        }

        public override void VisitNestedStaticClassMethodCollection<TMethod>(
            INestedStaticClassMethodCollection<TMethod> methodCollection)
        {
            Value = new NestedStaticClassMethodCollection()
            {
                Methods = methodCollection.ToList(method => new StaticClassMethodWrapper(method).Value)
            };
        }
    }
}
