namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractClasses
{
    public struct StructWithNestedAbstractPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class<T>
            where T : class, new()
        {
        }
    }
}
