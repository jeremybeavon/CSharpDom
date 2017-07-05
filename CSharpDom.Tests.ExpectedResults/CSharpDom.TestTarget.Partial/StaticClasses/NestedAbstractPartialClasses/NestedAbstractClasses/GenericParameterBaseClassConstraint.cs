namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedAbstractPartialClassWithNestedAbstractPartialClassWithGenericParameterBaseClassConstraint
    {
        public abstract partial class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
