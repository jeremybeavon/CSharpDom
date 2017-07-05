namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs
{
    public class ClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct<T>
            where T : new()
        {
        }
    }
}
