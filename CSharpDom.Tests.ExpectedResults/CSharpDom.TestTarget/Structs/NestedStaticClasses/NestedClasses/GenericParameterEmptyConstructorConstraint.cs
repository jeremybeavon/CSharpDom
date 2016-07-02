namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedClasses
{
    public struct StructWithNestedStaticClassWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
