namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public struct StructWithNestedSealedPartialClassWithExplicitInterfaceMethodWith1GenericParameter
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
