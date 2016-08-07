namespace CSharpDom.TestTarget.Classes.NestedStructs.NestedStaticClasses
{
    public class ClassWithNestedStructWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
