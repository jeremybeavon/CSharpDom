namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses
{
    public struct StructWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public abstract class Class<T>
            where T : IInterface
        {
        }
    }
}
