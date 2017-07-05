namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedAbstractClasses
{
    public partial class PartialClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
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
