namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedSealedClassWithExplicitInterfaceMethodWith1GenericParameter
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
