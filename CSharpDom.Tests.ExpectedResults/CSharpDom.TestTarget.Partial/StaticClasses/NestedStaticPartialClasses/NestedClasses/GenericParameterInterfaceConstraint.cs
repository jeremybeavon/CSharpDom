namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedClasses
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedPartialClassWithGenericParameterInterfaceConstraint
    {
        public static partial class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
