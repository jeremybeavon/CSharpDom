namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedStaticClasses
{
    public partial class PartialClassWithNestedClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
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
