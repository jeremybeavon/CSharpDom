namespace CSharpDom.TestTarget.Structs
{
    public struct StructWithGenericParameterClassAndEmptyConstructorConstraints<T>
        where T : class, new()
    {
    }
}
