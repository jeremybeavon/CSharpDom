namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedStaticClasses
{
    public partial class PartialClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
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
