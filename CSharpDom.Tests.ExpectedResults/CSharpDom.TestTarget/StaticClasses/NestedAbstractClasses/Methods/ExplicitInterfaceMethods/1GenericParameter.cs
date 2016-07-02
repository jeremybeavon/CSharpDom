namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Methods.ExplicitInterfaceMethods
{
    public static class StaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWith1GenericParameter
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
