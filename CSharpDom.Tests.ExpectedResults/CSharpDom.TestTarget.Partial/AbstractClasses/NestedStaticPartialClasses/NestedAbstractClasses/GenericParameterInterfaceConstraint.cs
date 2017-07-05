namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedAbstractPartialClassWithGenericParameterInterfaceConstraint
    {
        public static partial class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
