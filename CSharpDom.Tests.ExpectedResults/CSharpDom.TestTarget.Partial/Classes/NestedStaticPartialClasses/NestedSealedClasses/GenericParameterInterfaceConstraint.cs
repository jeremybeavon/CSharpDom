namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedSealedClasses
{
    public class ClassWithNestedStaticPartialClassWithNestedSealedPartialClassWithGenericParameterInterfaceConstraint
    {
        public static partial class Class
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
