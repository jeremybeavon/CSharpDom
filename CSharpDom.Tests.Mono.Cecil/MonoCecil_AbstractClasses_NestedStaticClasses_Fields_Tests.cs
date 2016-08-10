using CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStaticClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithConstFieldUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithInternalFieldUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithPrivateFieldUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithPublicFieldUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithVolatileFieldUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithVolatileField));
        }
    }
}
