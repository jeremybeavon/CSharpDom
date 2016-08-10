using CSharpDom.TestTarget.Classes.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithInternalAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNewAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNewVirtualAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithPublicAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithStaticAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithVirtualAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithVirtualAutoProperty));
        }
    }
}
