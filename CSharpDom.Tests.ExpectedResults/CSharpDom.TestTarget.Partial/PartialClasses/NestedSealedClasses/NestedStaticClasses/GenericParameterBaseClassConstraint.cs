namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedStaticClasses
{
    public partial class PartialClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
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
