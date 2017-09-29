using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedSealedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}
