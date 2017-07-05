namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses
{
    public partial struct PartialStructWithWithNestedClassWithGenericParameterBaseClassConstraint
    {
        public class Class<T>
            where T : BaseClass
        {
        }
    }
}
