namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedClasses
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
