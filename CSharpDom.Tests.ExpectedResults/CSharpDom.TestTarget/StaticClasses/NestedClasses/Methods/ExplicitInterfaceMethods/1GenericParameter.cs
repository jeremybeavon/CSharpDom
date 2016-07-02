namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public static class StaticClassWithNestedClassWithExplicitInterfaceMethodWith1GenericParameter
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
