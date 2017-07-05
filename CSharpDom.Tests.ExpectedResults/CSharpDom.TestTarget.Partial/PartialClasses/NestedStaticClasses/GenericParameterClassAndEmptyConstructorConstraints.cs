namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses
{
    public partial class PartialClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class<T>
            where T : class, new()
        {
        }
    }
}
