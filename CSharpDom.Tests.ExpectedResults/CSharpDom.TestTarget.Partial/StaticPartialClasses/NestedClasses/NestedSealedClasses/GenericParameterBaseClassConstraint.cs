namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedSealedClasses
{
    public static partial class StaticPartialClassWithNestedClassWithNestedSealedClassWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
