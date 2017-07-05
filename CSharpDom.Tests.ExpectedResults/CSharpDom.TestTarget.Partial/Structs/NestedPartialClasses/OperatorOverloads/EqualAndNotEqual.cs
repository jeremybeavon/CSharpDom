namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.OperatorOverloads
{
    public struct StructWithNestedPartialClassWithEqualAndNotEqualOperatorOverloads
    {
        public partial class Class
        {
            public static bool operator ==(Class parameter1, Class parameter2)
            {
                return default(bool);
            }

            public static bool operator !=(Class parameter1, Class parameter2)
            {
                return default(bool);
            }
        }
    }
}
