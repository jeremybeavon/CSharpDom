namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedClasses
{
    public class ClassWithNestedStaticPartialClassWithNestedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static partial class Class
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
