namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedStructs
{
    public partial struct PartialStructWithWithNestedClassWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : BaseClass
            {
            }
        }
    }
}
