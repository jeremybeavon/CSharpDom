namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Methods
{
    public sealed partial class SealedPartialClassWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public T Method<T>()
            where T : new()
        {
            return default(T);
        }
    }
}
