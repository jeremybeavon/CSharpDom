namespace CSharpDom.TestTarget.Partial.PartialClasses.Methods
{
    public partial class PartialClassWithMethodWithGenericParameterBaseClassConstraint
    {
        public T Method<T>()
            where T : BaseClass
        {
            return default(T);
        }
    }
}
