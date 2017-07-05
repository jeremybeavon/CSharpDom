namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedAbstractClassWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
