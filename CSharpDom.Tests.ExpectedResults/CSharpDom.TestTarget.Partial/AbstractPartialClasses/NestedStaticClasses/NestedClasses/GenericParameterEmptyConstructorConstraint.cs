namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.NestedClasses
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
