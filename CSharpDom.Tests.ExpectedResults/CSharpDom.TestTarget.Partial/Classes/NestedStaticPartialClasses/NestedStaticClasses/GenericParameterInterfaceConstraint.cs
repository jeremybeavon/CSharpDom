namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedStaticClasses
{
    public class ClassWithNestedStaticPartialClassWithNestedStaticPartialClassWithGenericParameterInterfaceConstraint
    {
        public static partial class Class
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
