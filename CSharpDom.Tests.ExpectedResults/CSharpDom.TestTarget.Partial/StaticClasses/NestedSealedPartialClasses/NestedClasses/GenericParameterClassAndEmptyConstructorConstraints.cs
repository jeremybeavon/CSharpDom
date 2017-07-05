namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedClasses
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed partial class Class
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
