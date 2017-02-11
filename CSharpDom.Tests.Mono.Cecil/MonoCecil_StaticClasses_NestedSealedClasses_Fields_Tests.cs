using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedSealedClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithConstFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithInternalFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewStaticFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPrivateFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPublicFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithStaticFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithVolatileFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithVolatileField));
        }
    }
}
