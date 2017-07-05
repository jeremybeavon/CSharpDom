namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses
{
    public partial class PartialClassWithNestedClassWithGenericParameterBaseClassConstraint
    {
        public class Class<T>
            where T : BaseClass
        {
        }
    }
}
