namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedClasses
{
    public static class StaticClassWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
