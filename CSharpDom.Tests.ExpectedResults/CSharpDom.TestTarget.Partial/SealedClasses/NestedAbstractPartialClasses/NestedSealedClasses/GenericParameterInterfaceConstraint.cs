namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedSealedPartialClassWithGenericParameterInterfaceConstraint
    {
        public abstract partial class Class
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
