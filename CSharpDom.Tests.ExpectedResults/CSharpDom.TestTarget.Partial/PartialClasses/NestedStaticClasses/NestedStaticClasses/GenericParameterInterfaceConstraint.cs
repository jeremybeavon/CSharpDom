namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedStaticClasses
{
    public partial class PartialClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
