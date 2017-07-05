namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedStaticClasses
{
    public class ClassWithNestedStructWithNestedStaticPartialClassWithGenericParameterBaseClassConstraint
    {
        public struct Struct
        {
            public static class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
