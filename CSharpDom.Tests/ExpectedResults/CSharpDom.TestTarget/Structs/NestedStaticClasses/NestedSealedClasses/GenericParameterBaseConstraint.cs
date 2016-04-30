namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedSealedClasses
{
    public struct StructWithNestedStaticClassWithNestedSealedClassWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public sealed class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
