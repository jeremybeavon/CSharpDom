namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Methods
{
    public sealed partial class SealedPartialClassWithMethodWithGenericParameterClassConstraint
    {
        public T Method<T>()
            where T : class
        {
            return default(T);
        }
    }
}
