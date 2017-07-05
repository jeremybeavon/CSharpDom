namespace CSharpDom.TestTarget.Partial.PartialClasses.Methods
{
    public partial class PartialClassWithMethodWithGenericParameterClassConstraint
    {
        public T Method<T>()
            where T : class
        {
            return default(T);
        }
    }
}
