namespace CSharpDom.TestTarget.Classes.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedClassWithExplicitInterfaceMethodWith1GenericParameter
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
