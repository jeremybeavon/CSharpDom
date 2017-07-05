namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedStaticClasses
{
    public class ClassWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
