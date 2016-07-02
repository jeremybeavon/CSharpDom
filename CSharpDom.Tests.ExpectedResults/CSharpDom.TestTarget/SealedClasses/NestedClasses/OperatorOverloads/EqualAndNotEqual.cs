namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.OperatorOverloads
{
    public sealed class SealedClassWithNestedClassWithEqualAndNotEqualOperatorOverloads
    {
        public class Class
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
