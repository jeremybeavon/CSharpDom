namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedClasses
{
    public static class StaticClassWithNestedAbstractClassWithNestedClassWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
