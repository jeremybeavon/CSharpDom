namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractClasses
{
    public struct StructWithNestedAbstractPartialClassWithGenericParameterStructConstraint
    {
        public abstract class Class<T>
            where T : struct
        {
        }
    }
}
