namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedStaticPartialClassWithGenericParameterClassConstraint
    {
        public sealed partial class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
