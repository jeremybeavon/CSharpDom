namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedStaticClasses
{
    public static partial class StaticPartialClassWithNestedClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
