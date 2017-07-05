namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedStaticClasses
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
