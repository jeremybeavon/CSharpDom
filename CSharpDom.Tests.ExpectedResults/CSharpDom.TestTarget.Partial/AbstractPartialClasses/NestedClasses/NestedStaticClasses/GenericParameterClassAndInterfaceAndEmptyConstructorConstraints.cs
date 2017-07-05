namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedStaticClasses
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
