using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedSealedClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithInternalPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithOverridePropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPrivatePropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPublicPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithStaticPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticProperty));
        }
    }
}
