namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedStaticClasses
{
    public struct StructWithNestedClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
