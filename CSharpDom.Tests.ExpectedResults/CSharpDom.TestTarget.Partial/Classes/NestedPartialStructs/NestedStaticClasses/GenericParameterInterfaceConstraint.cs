namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedStaticClasses
{
    public class ClassWithNestedStructWithNestedStaticPartialClassWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
