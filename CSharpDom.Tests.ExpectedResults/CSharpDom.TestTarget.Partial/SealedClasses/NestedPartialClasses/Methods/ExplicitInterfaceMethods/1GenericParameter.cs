namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedPartialClassWithExplicitInterfaceMethodWith1GenericParameter
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
