namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.NestedClasses
{
    public static class StaticClassWithNestedAbstractPartialClassWithNestedPartialClassWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
