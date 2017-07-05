namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.OperatorOverloads
{
    public static class StaticClassWithNestedPartialClassWithEqualAndNotEqualOperatorOverloads
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
