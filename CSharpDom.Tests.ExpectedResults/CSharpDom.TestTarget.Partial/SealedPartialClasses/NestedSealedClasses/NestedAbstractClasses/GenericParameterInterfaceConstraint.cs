namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedAbstractClasses
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
