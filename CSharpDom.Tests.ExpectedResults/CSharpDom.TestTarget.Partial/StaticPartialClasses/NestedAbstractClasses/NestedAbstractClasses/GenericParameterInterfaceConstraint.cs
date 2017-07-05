namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
