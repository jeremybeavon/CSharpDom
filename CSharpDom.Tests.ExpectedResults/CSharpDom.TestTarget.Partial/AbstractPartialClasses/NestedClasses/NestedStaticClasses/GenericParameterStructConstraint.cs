namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedStaticClasses
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
