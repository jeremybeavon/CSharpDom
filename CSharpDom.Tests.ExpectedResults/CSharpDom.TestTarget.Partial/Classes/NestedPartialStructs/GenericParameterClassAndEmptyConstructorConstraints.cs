namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs
{
    public class ClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct<T>
            where T : class, new()
        {
        }
    }
}
