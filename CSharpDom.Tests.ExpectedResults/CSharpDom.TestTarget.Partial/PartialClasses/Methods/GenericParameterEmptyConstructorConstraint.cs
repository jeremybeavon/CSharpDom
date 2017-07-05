namespace CSharpDom.TestTarget.Partial.PartialClasses.Methods
{
    public partial class PartialClassWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public T Method<T>()
            where T : new()
        {
            return default(T);
        }
    }
}
