namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses
{
    public struct StructWithNestedAbstractClassWithGenericParameterClassConstraint
    {
        public abstract class Class<T>
            where T : class
        {
        }
    }
}
