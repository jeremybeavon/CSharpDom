namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedClasses
{
    public class ClassWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterBaseClassConstraint
    {
        public sealed partial class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
