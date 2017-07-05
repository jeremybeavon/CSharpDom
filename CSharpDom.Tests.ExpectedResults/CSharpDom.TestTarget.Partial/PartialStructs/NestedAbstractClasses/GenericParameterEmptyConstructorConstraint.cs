namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class<T>
            where T : new()
        {
        }
    }
}
