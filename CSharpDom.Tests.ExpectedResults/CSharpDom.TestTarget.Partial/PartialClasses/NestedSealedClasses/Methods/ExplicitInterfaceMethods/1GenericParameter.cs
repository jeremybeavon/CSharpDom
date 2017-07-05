namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public partial class PartialClassWithNestedSealedClassWithExplicitInterfaceMethodWith1GenericParameter
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
