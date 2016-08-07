namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedAbstractClasses
{
    public class ClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
