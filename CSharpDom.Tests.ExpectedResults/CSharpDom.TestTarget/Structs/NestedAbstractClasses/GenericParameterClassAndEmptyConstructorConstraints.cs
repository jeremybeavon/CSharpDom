namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses
{
    public struct StructWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class<T>
            where T : class, new()
        {
        }
    }
}
