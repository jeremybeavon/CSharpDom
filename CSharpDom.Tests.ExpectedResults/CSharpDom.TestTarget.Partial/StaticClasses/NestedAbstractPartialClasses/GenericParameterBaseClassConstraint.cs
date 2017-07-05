namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedAbstractPartialClassWithGenericParameterBaseClassConstraint
    {
        public abstract class Class<T>
            where T : BaseClass
        {
        }
    }
}
