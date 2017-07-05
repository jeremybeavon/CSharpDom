namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses
{
    public partial struct PartialStructWithWithNestedClassWithGenericParameterClassConstraint
    {
        public class Class<T>
            where T : class
        {
        }
    }
}
