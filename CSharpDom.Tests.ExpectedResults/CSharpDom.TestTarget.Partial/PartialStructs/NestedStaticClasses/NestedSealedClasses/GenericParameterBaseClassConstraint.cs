namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedSealedClasses
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedSealedClassWithGenericParameterBaseClassConstraint
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
