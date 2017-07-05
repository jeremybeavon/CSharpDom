namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedClasses
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedPartialClassWithGenericParameterBaseClassConstraint
    {
        public static partial class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
