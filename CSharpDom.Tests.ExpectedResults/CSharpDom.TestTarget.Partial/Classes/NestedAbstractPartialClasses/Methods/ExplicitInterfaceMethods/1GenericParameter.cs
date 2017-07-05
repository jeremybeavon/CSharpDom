namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedAbstractPartialClassWithExplicitInterfaceMethodWith1GenericParameter
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
