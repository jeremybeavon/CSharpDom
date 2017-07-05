namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedSealedClasses
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedSealedClassWithGenericParameterInterfaceConstraint
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
