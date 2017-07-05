namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedAbstractClasses
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
