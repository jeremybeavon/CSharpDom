namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterStructConstraint
    {
        public partial class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
