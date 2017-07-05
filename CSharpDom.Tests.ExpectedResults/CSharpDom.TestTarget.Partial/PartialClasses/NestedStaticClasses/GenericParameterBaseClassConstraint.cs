namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses
{
    public partial class PartialClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public static class Class<T>
            where T : BaseClass
        {
        }
    }
}
