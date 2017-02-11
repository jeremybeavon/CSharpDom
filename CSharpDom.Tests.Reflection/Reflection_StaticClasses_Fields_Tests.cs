using CSharpDom.TestTarget.StaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithConstFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithConstField));
        }

        [TestMethod]
        public void TestStaticClassWithInternalFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithPrivateFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestStaticClassWithPublicFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithPublicField));
        }

        [TestMethod]
        public void TestStaticClassWithReadOnlyFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithVolatileFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithVolatileField));
        }
    }
}
