using CSharpDom.TestTarget.StaticClasses.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalAutoPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewAutoPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewVirtualAutoPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicAutoPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticAutoPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualAutoPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
