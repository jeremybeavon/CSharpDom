namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.NestedClasses
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithNestedClassWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
