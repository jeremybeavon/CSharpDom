namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedStaticClasses
{
    public struct StructWithNestedClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
