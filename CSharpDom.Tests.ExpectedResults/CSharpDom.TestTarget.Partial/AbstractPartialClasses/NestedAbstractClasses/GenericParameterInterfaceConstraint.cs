namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public abstract class Class<T>
            where T : IInterface
        {
        }
    }
}
