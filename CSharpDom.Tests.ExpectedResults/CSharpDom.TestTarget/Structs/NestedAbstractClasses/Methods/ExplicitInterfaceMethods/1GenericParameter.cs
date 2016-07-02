namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Methods.ExplicitInterfaceMethods
{
    public struct StructWithNestedAbstractClassWithExplicitInterfaceMethodWith1GenericParameter
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
