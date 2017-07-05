namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.NestedStaticClasses
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
