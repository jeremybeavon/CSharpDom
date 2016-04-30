namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedStaticClasses
{
    public struct StructWithNestedSealedClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
