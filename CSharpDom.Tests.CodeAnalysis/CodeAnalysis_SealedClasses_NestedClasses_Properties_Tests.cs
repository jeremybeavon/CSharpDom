using CSharpDom.TestTarget.SealedClasses.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewVirtualPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverridePropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivatePropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVirtualProperty));
        }
    }
}
