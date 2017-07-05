namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedPartialClassWithNestedAbstractPartialClassWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
