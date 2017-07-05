namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedClasses
{
    public static partial class StaticPartialClassWithNestedClassWithNestedClassWithGenericParameterClassConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
