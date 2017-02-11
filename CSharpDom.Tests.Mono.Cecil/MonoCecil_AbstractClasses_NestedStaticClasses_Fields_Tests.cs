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
            TestAbstractClass(typeof(AbstractClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithInternalFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithPrivateFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithPublicFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithVolatileFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStaticClassWithVolatileField));
        }
    }
}
