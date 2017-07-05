namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses
{
    public partial class PartialClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class<T>
            where T : new()
        {
        }
    }
}
