namespace CSharpDom.TestTarget.Partial.PartialClasses.Methods
{
    public partial class PartialClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public T Method<T>()
            where T : class, new()
        {
            return default(T);
        }
    }
}
