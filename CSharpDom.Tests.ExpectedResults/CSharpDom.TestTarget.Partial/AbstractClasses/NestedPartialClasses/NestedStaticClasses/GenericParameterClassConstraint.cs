namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
