namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Methods
{
    public struct StructWithNestedSealedClassWithMethodWithGenericParameterClassConstraint
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
