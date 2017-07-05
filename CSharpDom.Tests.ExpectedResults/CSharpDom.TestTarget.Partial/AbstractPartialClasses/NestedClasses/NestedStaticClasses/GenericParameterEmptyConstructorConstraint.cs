namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedStaticClasses
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
