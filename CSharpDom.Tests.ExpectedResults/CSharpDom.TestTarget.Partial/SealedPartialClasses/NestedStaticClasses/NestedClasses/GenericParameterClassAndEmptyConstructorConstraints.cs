namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
