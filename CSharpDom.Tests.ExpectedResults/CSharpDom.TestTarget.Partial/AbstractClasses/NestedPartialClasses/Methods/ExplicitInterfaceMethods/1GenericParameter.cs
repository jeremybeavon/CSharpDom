namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassWithNestedPartialClassWithExplicitInterfaceMethodWith1GenericParameter
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
