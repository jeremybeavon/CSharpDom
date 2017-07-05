namespace CSharpDom.TestTarget.Partial.PartialClasses.Methods
{
    public partial class PartialClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public T Method<T>()
            where T : IInterface
        {
            return default(T);
        }
    }
}
