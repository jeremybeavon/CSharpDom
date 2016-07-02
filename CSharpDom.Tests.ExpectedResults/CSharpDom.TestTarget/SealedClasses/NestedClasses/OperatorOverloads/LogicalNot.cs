namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.OperatorOverloads
{
    public sealed class SealedClassWithNestedClassWithLogicalNotOperatorOverload
    {
        public class Class
        {
            public static bool operator !(Class parameter1)
            {
                return default(bool);
            }
        }
    }
}
