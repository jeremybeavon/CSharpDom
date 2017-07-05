namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedAbstractClasses
{
    public partial class PartialClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
