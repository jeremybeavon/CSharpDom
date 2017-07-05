namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedStaticClasses
{
    public partial struct PartialStructWithWithNestedClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
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
