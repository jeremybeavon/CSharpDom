namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedClasses
{
    public class ClassWithNestedStaticPartialClassWithNestedPartialClassWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
