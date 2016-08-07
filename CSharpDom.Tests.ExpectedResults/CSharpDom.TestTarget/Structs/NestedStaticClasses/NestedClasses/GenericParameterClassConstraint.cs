namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedClasses
{
    public struct StructWithNestedStaticClassWithNestedClassWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
