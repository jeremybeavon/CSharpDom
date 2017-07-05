namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
