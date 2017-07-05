namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Methods.ExplicitInterfaceMethods
{
    public static class StaticClassWithNestedAbstractPartialClassWithExplicitInterfaceMethodWith1GenericParameter
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
