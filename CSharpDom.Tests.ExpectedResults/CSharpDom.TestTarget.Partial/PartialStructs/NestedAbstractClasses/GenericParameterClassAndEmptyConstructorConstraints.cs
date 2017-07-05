namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class<T>
            where T : class, new()
        {
        }
    }
}
