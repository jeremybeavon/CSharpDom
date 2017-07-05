namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedStaticPartialClassWithNestedAbstractPartialClassWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
