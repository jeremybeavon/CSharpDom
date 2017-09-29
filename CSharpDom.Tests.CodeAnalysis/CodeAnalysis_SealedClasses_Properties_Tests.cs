using CSharpDom.TestTarget.SealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithInternalPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNewPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestSealedClassWithOverridePropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithPrivatePropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithPublicPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestSealedClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithStaticPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithStaticProperty));
        }
    }
}
