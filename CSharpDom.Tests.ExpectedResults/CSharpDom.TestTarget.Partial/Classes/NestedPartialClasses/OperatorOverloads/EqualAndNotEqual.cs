namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.OperatorOverloads
{
    public class ClassWithNestedPartialClassWithEqualAndNotEqualOperatorOverloads
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
