namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses
{
    public partial struct PartialStructWithWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class<T>
            where T : new()
        {
        }
    }
}
