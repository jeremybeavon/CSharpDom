namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedClasses
{
    public static class StaticClassWithNestedPartialClassWithNestedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
