namespace CSharpDom.TestTarget.Structs.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public struct StructWithNestedClassWithExplicitInterfaceMethodWith1GenericParameter
    {
        public class Class : IInterfaceWithMethodWith1GenericParameter
        {
            T IInterfaceWithMethodWith1GenericParameter.Method<T>()
            {
                return default(T);
            }
        }
    }
}
