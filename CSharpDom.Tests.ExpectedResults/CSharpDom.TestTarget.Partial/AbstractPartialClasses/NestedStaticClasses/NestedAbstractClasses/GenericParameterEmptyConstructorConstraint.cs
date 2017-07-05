namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.NestedAbstractClasses
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
