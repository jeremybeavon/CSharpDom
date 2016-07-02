namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public struct StructWithNestedSealedClassWithExplicitInterfaceMethodWith1GenericParameter
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
