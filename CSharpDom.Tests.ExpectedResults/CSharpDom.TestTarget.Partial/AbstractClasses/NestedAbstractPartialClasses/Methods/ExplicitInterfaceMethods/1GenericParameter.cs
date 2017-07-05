namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithExplicitInterfaceMethodWith1GenericParameter
    {
        public abstract class Class : IInterfaceWithMethodWith1GenericParameter
        {
            T IInterfaceWithMethodWith1GenericParameter.Method<T>()
            {
                return default(T);
            }
        }
    }
}
