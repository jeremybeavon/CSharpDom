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
            TestStaticClassAsync(typeof(StaticClassWithConstField));
        }

        [TestMethod]
        public void TestStaticClassWithInternalFieldUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithPrivateFieldUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestStaticClassWithPublicFieldUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithPublicField));
        }

        [TestMethod]
        public void TestStaticClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithVolatileFieldUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithVolatileField));
        }
    }
}
