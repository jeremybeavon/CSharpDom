namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedStaticPartialClassWithGenericParameterInterfaceConstraint
    {
        public abstract partial class Class
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
