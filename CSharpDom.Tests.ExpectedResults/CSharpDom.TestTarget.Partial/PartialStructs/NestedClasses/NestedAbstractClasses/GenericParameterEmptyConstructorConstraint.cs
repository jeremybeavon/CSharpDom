namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
