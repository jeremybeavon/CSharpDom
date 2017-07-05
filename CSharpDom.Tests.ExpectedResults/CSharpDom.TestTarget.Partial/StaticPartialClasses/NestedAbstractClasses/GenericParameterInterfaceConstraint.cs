namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public abstract class Class<T>
            where T : IInterface
        {
        }
    }
}
