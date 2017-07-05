namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Methods
{
    public partial class PartialClassWithNestedSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public T Method<T>()
                where T : class, new()
            {
                return default(T);
            }
        }
    }
}
