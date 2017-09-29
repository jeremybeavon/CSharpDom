using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedAbstractClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithInternalPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewVirtualPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithOverridePropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPrivatePropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPublicPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithStaticPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithVirtualPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithVirtualProperty));
        }
    }
}
