using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStructs_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStructWithConstFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithConstField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithInternalFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPrivateFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPublicFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithPublicField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithReadOnlyFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithStaticFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithStaticVolatileFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithVolatileFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithVolatileField));
        }
    }
}
