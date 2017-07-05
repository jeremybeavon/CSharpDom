namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Constructors
{
    public partial class PartialClassWithNestedSealedClassWithConstructorWithParametersWithModifiers
    {
        public sealed class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
