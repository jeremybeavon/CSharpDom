namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
