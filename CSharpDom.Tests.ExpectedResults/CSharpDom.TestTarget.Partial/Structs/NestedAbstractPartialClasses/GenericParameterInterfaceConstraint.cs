namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractClasses
{
    public struct StructWithNestedAbstractPartialClassWithGenericParameterInterfaceConstraint
    {
        public abstract class Class<T>
            where T : IInterface
        {
        }
    }
}
