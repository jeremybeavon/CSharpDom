using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class SealedClassMethodCollectionWrapper :
        AbstractWrapper<ISealedClassMethodCollection>
    {
        public SealedClassMethodCollectionWrapper(ISealedClassMethodCollection methodCollection)
            : base(methodCollection)
        {
        }

        public override void VisitSealedClassMethodCollection<TMethod, TExplicitInterfaceMethod>(
            ISealedClassMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection)
        {
            Value = new SealedClassMethodCollection()
            {
                Methods = methodCollection.ToList(method => new SealedClassMethodWrapper(method).Value),
                ExplicitInterfaceMethods = methodCollection.ExplicitInterfaceMethods.ToList(method => new ExplicitInterfaceMethodWrapper(method).Value)
            };
        }
    }
}
