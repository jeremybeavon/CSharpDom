namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedAbstractClasses
{
    public partial class PartialClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
