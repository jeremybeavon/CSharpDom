namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedStaticClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
