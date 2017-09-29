using CSharpDom.TestTarget.SealedClasses.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewVirtualAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
