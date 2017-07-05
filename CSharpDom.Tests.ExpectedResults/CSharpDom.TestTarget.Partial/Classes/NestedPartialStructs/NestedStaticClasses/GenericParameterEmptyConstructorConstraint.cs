namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedStaticClasses
{
    public class ClassWithNestedStructWithNestedStaticPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
