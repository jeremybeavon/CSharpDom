namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public static partial class StaticPartialClassWithNestedSealedClassWithExplicitInterfaceMethodWith1GenericParameter
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
