namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedStructs
{
    public class ClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
