namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedStaticClasses
{
    public struct StructWithNestedClassWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
