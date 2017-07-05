namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedClasses
{
    public partial class PartialClassWithNestedStaticClassWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
