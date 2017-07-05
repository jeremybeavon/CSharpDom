namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedClasses
{
    public partial class PartialClassWithNestedStaticClassWithNestedClassWithGenericParameterStructConstraint
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
