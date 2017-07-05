namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedAbstractPartialClassWithGenericParameterInterfaceConstraint
    {
        public abstract partial class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
