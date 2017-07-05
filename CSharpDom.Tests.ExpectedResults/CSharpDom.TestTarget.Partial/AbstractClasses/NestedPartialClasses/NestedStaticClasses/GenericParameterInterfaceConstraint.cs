namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterInterfaceConstraint
    {
        public partial class Class
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
