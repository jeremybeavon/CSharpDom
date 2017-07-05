namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedStaticClasses
{
    public partial class PartialClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
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
