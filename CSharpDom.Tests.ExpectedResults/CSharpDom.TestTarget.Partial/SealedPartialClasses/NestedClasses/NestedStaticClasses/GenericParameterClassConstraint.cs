namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedStaticClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
