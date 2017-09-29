namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public partial struct PartialStructWithNestedSealedClassWithExplicitInterfaceMethodWith1GenericParameter
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
