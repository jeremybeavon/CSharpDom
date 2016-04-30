namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
