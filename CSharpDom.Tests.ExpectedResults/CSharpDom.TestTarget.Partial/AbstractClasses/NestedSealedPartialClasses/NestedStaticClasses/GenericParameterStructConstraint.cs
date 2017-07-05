namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedStaticPartialClassWithGenericParameterStructConstraint
    {
        public sealed partial class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
