namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedStaticClasses
{
    public class ClassWithNestedStructWithNestedStaticPartialClassWithGenericParameterStructConstraint
    {
        public struct Struct
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
