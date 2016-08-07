namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
