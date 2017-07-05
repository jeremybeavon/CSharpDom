namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Methods
{
    public sealed class SealedClassWithNestedStructWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public T Method<T>()
                where T : new()
            {
                return default(T);
            }
        }
    }
}
