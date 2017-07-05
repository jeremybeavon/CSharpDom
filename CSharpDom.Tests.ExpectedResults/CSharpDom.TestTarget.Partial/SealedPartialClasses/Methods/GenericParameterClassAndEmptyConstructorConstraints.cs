namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Methods
{
    public sealed partial class SealedPartialClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public T Method<T>()
            where T : class, new()
        {
            return default(T);
        }
    }
}
