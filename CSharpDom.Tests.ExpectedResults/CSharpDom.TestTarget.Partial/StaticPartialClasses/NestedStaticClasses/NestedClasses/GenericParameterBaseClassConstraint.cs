namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedClasses
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedClassWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
