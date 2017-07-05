namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses
{
    public partial class PartialClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public abstract class Class<T>
            where T : IInterface
        {
        }
    }
}
