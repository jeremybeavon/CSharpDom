namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Methods.ExplicitInterfaceMethods
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithExplicitInterfaceMethodWith1GenericParameter
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
