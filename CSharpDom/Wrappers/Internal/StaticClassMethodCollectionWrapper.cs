using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class StaticClassMethodCollectionWrapper :
        AbstractWrapper<IStaticClassMethodCollection>
    {
        public StaticClassMethodCollectionWrapper(IStaticClassMethodCollection methodCollection)
            : base(methodCollection)
        {
        }

        public override void VisitStaticClassMethodCollection<TMethod, TExtensionMethod>(
            IStaticClassMethodCollection<TMethod, TExtensionMethod> methodCollection)
        {
            Value = new StaticClassMethodCollection()
            {
                Methods = methodCollection.ToList(method => new StaticClassMethodWrapper(method).Value),
                ExtensionMethods = methodCollection.ExtensionMethods.ToList(method => new ExtensionMethodWrapper(method).Value)
            };
        }
    }
}
