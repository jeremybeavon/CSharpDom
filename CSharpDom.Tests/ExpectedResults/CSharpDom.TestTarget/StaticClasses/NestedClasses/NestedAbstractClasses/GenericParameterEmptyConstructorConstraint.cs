namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
