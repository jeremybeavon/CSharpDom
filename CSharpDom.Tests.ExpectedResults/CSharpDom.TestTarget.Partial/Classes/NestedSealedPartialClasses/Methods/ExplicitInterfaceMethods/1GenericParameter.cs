namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedSealedPartialClassWithExplicitInterfaceMethodWith1GenericParameter
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
