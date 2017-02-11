using CSharpDom.TestTarget.StaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithConstFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithConstField));
        }

        [TestMethod]
        public void TestStaticClassWithInternalFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithPrivateFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestStaticClassWithPublicFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithPublicField));
        }

        [TestMethod]
        public void TestStaticClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithVolatileFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithVolatileField));
        }
    }
}
