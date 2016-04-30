namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedClasses
{
    public static class StaticClassWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
