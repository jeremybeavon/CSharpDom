namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public static class StaticClassWithNestedSealedPartialClassWithExplicitInterfaceMethodWith1GenericParameter
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
