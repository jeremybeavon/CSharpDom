namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedClassWithExplicitInterfaceMethodWith1GenericParameter
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
