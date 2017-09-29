using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedAbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewVirtualAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithVirtualAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithVirtualAutoProperty));
        }
    }
}
