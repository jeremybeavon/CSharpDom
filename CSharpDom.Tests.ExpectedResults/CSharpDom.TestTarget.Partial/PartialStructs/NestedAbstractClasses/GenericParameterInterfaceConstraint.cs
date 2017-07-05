namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public abstract class Class<T>
            where T : IInterface
        {
        }
    }
}
