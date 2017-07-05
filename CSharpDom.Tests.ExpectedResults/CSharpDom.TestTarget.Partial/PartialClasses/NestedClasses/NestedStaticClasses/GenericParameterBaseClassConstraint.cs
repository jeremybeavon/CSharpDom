namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedStaticClasses
{
    public partial class PartialClassWithNestedClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
