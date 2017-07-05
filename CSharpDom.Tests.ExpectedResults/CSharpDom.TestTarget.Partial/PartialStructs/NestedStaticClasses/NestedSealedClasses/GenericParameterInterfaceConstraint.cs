namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedSealedClasses
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedSealedClassWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
