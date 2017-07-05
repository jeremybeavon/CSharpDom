namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedSealedClasses
{
    public class ClassWithNestedStaticPartialClassWithNestedSealedPartialClassWithGenericParameterBaseClassConstraint
    {
        public static partial class Class
        {
            public sealed class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
