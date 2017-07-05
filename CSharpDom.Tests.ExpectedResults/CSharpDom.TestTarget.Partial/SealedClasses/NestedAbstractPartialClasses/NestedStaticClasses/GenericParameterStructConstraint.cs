namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedStaticPartialClassWithGenericParameterStructConstraint
    {
        public abstract partial class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
