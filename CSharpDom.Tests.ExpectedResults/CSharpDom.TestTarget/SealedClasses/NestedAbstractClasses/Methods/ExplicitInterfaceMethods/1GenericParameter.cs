namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedAbstractClassWithExplicitInterfaceMethodWith1GenericParameter
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
