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
            TestStaticClassAsync(typeof(StaticClassWithConstField));
        }

        [TestMethod]
        public void TestStaticClassWithInternalFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithPrivateFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestStaticClassWithPublicFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithPublicField));
        }

        [TestMethod]
        public void TestStaticClassWithReadOnlyFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithVolatileFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithVolatileField));
        }
    }
}
