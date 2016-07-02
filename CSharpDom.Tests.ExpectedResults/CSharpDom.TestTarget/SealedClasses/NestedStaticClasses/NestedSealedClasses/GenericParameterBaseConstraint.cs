namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterBaseClassConstraint
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
