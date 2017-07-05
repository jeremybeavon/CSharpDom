namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Constructors
{
    public abstract class AbstractClassWithNestedPartialClassWithConstructorWithParametersWithModifiers
    {
        public partial class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
