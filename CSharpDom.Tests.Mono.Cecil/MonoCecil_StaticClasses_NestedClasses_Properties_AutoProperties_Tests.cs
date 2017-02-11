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
            TestStaticClass(typeof(StaticClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewAutoPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewVirtualAutoPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicAutoPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPublicAutoProperty));
        }

        //[TestMethod]
        //public void TestStaticClassWithNestedClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        //{
        //    TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideAutoProperty));
        //}

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticAutoPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualAutoPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
