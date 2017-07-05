namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint
    {
        public abstract class Class<T>
            where T : BaseClass
        {
        }
    }
}
