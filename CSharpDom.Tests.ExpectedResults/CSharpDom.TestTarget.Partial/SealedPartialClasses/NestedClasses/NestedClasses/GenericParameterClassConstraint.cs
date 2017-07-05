namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedClassWithGenericParameterClassConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
