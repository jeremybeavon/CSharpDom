namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedClasses
{
    public class ClassWithNestedStaticPartialClassWithNestedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public static partial class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
