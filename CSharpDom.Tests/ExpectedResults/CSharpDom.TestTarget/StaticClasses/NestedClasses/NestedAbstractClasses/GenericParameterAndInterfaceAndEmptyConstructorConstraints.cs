namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
