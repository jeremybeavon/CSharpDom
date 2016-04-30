namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
