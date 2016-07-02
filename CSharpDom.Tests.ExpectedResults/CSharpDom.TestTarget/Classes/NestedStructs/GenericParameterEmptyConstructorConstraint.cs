namespace CSharpDom.TestTarget.Classes.NestedStructs
{
    public class ClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct<T>
            where T : new()
        {
        }
    }
}
