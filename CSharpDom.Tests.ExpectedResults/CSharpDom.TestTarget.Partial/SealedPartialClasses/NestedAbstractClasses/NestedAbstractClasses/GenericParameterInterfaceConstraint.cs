namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
