namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedStaticClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
