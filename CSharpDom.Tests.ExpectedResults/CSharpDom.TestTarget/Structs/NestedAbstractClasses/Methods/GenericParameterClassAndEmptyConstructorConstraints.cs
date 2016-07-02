namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Methods
{
    public struct StructWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
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
