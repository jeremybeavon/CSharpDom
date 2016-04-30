namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public static class StaticClassWithNestedSealedClassWithExplicitInterfaceMethodWith1GenericParameter
    {
        public sealed class Class : IInterfaceWithMethodWith1GenericParameter
        {
            T IInterfaceWithMethodWith1GenericParameter.Method<T>()
            {
                return default(T);
            }
        }
    }
}
