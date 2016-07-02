namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public static class Class<T>
            where T : BaseClass
        {
        }
    }
}
