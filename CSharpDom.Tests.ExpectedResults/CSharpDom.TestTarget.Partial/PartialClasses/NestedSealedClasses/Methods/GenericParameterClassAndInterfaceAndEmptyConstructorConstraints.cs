namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Methods
{
    public partial class PartialClassWithNestedSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public T Method<T>()
                where T : class, IInterface, new()
            {
                return default(T);
            }
        }
    }
}
