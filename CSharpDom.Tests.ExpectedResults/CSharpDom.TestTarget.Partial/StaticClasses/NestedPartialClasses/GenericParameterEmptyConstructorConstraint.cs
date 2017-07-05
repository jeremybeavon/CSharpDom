namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedClasses
{
    public static class StaticClassWithNestedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class<T>
            where T : new()
        {
        }
    }
}
