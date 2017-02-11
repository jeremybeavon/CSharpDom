using CSharpDom.TestTarget.Classes.NestedStructs.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStructs_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithConstFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithConstField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithPublicField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithReadOnlyFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticVolatileFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithVolatileFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithVolatileField));
        }
    }
}
