namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Methods
{
    public partial struct PartialStructWithWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public T Method<T>()
                where T : class, new()
            {
                return default(T);
            }
        }
    }
}
