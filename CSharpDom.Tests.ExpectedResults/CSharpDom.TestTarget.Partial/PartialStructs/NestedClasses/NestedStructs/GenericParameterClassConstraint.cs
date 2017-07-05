namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedStructs
{
    public partial struct PartialStructWithWithNestedClassWithNestedStructWithGenericParameterClassConstraint
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
