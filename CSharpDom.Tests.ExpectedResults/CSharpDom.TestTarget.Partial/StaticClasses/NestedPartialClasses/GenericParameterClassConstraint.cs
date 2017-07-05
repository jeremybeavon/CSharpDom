namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedClasses
{
    public static class StaticClassWithNestedPartialClassWithGenericParameterClassConstraint
    {
        public class Class<T>
            where T : class
        {
        }
    }
}
