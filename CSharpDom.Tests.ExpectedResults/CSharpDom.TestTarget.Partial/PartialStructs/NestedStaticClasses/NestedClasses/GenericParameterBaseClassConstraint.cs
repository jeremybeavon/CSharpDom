namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedClasses
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedClassWithGenericParameterBaseClassConstraint
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
