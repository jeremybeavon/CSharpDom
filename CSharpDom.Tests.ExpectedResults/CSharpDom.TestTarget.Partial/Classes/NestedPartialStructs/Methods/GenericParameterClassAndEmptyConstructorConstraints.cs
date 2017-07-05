namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Methods
{
    public class ClassWithNestedStructWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
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
