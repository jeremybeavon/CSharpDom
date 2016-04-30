namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassWithNestedClassWithExplicitInterfaceMethodWith1GenericParameter
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
