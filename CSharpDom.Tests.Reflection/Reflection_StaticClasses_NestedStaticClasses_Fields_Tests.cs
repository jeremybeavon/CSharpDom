using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedStaticClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithConstFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithInternalFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPrivateFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPublicFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithReadOnlyFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithVolatileFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithVolatileField));
        }
    }
}
