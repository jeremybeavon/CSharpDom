namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedClasses
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedClassWithGenericParameterStructConstraint
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
