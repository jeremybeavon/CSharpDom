namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedClasses
{
    public partial struct PartialStructWithWithNestedClassWithNestedClassWithGenericParameterClassConstraint
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
