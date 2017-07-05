namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedAbstractClasses
{
    public class ClassWithNestedStaticPartialClassWithNestedAbstractPartialClassWithGenericParameterInterfaceConstraint
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
