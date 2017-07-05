namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedClasses
{
    public partial class PartialClassWithNestedStaticClassWithNestedClassWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
