namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses
{
    public partial class PartialClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public static class Class<T>
            where T : struct
        {
        }
    }
}
