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
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithInternalFieldUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPrivateFieldUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPublicFieldUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithVolatileFieldUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithVolatileField));
        }
    }
}
