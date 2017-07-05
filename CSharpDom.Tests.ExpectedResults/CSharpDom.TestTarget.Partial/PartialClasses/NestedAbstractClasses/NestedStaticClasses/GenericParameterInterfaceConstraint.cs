namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedStaticClasses
{
    public partial class PartialClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
