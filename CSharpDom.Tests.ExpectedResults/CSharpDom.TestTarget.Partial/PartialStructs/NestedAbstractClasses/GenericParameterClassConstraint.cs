namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedAbstractClassWithGenericParameterClassConstraint
    {
        public abstract class Class<T>
            where T : class
        {
        }
    }
}
