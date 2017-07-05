namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedAbstractClassWithGenericParameterStructConstraint
    {
        public abstract class Class<T>
            where T : struct
        {
        }
    }
}
