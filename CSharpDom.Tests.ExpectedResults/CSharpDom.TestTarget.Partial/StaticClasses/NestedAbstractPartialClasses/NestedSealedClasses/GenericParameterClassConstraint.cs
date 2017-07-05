namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedAbstractPartialClassWithNestedSealedPartialClassWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
