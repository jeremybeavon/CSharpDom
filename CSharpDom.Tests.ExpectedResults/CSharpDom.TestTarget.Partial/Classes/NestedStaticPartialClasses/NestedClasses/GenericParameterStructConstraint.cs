namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedClasses
{
    public class ClassWithNestedStaticPartialClassWithNestedPartialClassWithGenericParameterStructConstraint
    {
        public static partial class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
