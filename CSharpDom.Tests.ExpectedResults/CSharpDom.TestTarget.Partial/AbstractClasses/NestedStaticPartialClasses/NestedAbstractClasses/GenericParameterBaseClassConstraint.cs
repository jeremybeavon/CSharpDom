namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedAbstractPartialClassWithGenericParameterBaseClassConstraint
    {
        public static partial class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
