namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedClasses
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
