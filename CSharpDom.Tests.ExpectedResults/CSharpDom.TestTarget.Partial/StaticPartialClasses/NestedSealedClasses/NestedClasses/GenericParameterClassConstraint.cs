namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedClasses
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedClassWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
