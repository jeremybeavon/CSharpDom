namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Methods.ExplicitInterfaceMethods
{
    public struct StructWithNestedAbstractPartialClassWithExplicitInterfaceMethodWith1GenericParameter
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
