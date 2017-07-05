namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedAbstractClasses
{
    public partial class PartialClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint
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
