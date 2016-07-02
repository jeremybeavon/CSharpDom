namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedStructs
{
    public sealed class SealedClassWithNestedStaticClassWithNestedStructWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
