namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractClasses
{
    public struct StructWithNestedAbstractPartialClassWithGenericParameterClassConstraint
    {
        public abstract class Class<T>
            where T : class
        {
        }
    }
}
