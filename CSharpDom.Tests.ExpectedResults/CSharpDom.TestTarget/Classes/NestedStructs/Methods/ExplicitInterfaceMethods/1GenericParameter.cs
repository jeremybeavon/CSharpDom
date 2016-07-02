namespace CSharpDom.TestTarget.Classes.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedStructWithExplicitInterfaceMethodWith1GenericParameter
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
