namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedStructWithExplicitInterfaceMethodWith1GenericParameter
    {
        public struct Struct : IInterfaceWithMethodWith1GenericParameter
        {
            T IInterfaceWithMethodWith1GenericParameter.Method<T>()
            {
                return default(T);
            }
        }
    }
}
