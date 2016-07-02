namespace CSharpDom.TestTarget.Classes.NestedStructs
{
    public class ClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct<T>
            where T : class, new()
        {
        }
    }
}
