namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedStaticClasses
{
    public partial struct PartialStructWithWithNestedClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
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
