using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedStaticClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithConstFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithInternalFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPrivateFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPublicFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithVolatileFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithVolatileField));
        }
    }
}
