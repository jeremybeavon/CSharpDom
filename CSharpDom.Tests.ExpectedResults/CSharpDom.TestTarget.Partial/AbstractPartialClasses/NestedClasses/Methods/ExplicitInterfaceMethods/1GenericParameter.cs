namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public abstract partial class AbstractPartialClassWithNestedClassWithExplicitInterfaceMethodWith1GenericParameter
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
