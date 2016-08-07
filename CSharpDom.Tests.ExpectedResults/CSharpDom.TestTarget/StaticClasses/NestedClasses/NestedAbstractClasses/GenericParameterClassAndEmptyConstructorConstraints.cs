namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
