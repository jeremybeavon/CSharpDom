namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedSealedClasses
{
    public struct StructWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
