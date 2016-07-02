namespace CSharpDom.TestTarget.SealedClasses
{
    public sealed class SealedClassWithGenericParameterClassAndEmptyConstructorConstraints<T>
        where T : class, new()
    {
    }
}
