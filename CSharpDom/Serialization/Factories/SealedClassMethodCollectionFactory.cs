using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class SealedClassMethodCollectionFactory :
        AbstractFactory<ISealedClassMethodCollection, SealedClassMethodCollection>
    {
        public SealedClassMethodCollectionFactory(ISealedClassMethodCollection methodCollection)
            : base(methodCollection)
        {
        }

        public override void VisitSealedClassMethodCollection<TMethod, TProtectedOverrideMethod, TExplicitInterfaceMethod>(
            ISealedClassMethodCollection<TMethod, TProtectedOverrideMethod, TExplicitInterfaceMethod> methodCollection)
        {
            Value = new SealedClassMethodCollection()
            {
                Methods = methodCollection.ToList(method => new SealedClassMethodFactory(method).Value),
                ProtectedOverrideMethods = methodCollection.ProtectedOverrideMethods.ToList(method => new ProtectedOverrideMethodFactory(method).Value),
                ExplicitInterfaceMethods = methodCollection.ExplicitInterfaceMethods.ToList(method => new ExplicitInterfaceMethodFactory(method).Value)
            };
        }
    }
}
