namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public static partial class StaticPartialClassWithNestedClassWithExplicitInterfaceMethodWith1GenericParameter
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
