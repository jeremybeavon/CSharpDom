namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
