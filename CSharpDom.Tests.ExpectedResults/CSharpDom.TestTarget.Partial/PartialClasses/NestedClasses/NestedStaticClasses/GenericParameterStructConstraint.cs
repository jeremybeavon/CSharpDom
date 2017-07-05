namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedStaticClasses
{
    public partial class PartialClassWithNestedClassWithNestedStaticClassWithGenericParameterStructConstraint
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
