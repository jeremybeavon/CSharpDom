namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedStaticClasses
{
    public class ClassWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterInterfaceConstraint
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
