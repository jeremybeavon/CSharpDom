namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedStaticClasses
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
