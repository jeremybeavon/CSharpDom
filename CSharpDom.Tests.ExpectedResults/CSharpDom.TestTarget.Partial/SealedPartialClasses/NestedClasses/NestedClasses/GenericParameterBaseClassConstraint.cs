namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedClassWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
