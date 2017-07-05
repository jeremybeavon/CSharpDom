namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedClasses
{
    public partial class PartialClassWithNestedClassWithNestedClassWithGenericParameterBaseClassConstraint
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
