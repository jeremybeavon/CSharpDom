namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedStaticClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
