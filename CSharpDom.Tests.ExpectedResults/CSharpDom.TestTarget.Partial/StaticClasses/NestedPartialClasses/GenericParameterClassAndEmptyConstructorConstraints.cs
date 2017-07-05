namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedClasses
{
    public static class StaticClassWithNestedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class<T>
            where T : class, new()
        {
        }
    }
}
