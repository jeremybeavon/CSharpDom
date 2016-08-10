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
            TestClassAsync(typeof(ClassWithNestedStructWithConstField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithReadOnlyFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticVolatileFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithVolatileFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithVolatileField));
        }
    }
}
