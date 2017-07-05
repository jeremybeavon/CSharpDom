namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedStructs
{
    public partial struct PartialStructWithWithNestedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
