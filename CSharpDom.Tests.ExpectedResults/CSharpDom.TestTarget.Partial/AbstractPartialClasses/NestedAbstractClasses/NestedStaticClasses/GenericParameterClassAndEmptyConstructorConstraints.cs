namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.NestedStaticClasses
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
