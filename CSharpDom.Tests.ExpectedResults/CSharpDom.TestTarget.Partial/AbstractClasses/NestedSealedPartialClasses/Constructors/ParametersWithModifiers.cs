namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Constructors
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithConstructorWithParametersWithModifiers
    {
        public sealed partial class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
