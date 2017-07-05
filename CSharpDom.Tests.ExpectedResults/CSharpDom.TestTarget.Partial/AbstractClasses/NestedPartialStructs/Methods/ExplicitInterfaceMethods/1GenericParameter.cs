namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassWithNestedStructWithExplicitInterfaceMethodWith1GenericParameter
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
