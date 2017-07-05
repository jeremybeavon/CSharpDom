namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.OperatorOverloads
{
    public partial class PartialClassWithNestedSealedClassWithLogicalNotOperatorOverload
    {
        public sealed class Class
        {
            public static bool operator !(Class parameter1)
            {
                return default(bool);
            }
        }
    }
}
