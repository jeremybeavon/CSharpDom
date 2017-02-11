using CSharpDom.TestTarget.StaticClasses.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVolatileFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithVolatileField));
        }
    }
}
