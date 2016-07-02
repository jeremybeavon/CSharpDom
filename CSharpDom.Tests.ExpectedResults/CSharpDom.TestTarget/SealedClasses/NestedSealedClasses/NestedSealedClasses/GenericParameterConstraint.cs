namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
