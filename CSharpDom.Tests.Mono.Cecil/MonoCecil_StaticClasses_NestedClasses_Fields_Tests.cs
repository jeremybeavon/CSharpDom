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
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalFieldUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewFieldUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticFieldUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateFieldUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedFieldUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicFieldUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticFieldUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVolatileFieldUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVolatileField));
        }
    }
}
