namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedAbstractPartialClassWithGenericParameterInterfaceConstraint
    {
        public sealed partial class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
