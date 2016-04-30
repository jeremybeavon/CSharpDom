namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedSealedClassWithExplicitInterfaceMethodWith1GenericParameter
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
