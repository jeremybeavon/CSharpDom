namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedStaticClasses
{
    public partial class PartialClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
