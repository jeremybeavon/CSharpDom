namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Methods
{
    public partial struct PartialStructWithWithNestedSealedClassWithMethodWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}
