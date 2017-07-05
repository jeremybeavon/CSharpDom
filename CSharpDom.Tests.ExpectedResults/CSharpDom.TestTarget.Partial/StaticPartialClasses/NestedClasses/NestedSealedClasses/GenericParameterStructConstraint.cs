namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedSealedClasses
{
    public static partial class StaticPartialClassWithNestedClassWithNestedSealedClassWithGenericParameterStructConstraint
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
