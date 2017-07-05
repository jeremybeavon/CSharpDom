namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Methods
{
    public sealed class SealedClassWithNestedStructWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public T Method<T>()
                where T : class, new()
            {
                return default(T);
            }
        }
    }
}
