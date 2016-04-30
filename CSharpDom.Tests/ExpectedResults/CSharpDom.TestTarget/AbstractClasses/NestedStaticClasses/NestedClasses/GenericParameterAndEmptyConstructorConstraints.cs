namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
