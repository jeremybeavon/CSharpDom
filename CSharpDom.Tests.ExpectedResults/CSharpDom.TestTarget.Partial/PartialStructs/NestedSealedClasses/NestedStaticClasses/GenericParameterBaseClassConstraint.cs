namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedStaticClasses
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public sealed class Class
        {
            public static class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
