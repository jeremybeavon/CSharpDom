namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.NestedClasses
{
    public static class StaticClassWithNestedAbstractPartialClassWithNestedPartialClassWithGenericParameterStructConstraint
    {
        public abstract partial class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
