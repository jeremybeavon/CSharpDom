namespace CSharpDom.TestTarget.Structs
{
    public struct StructWithGenericParameterEmptyConstructorConstraint<T>
        where T : new()
    {
    }
}
