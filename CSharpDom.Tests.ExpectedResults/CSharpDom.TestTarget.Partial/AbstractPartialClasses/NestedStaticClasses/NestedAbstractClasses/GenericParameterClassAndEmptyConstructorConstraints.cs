namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.NestedAbstractClasses
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
