namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNestedSealedClassWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
