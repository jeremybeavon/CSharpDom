namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedClasses
{
    public partial class PartialClassWithNestedStaticClassWithNestedClassWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
