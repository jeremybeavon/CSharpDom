namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedClasses
{
    public static partial class StaticPartialClassWithNestedClassWithNestedClassWithGenericParameterStructConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
