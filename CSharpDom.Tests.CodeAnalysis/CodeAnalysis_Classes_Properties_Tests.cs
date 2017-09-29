using CSharpDom.TestTarget.Classes.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithInternalPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNewPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNewProperty));
        }

        [TestMethod]
        public void TestClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestClassWithNewVirtualPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestClassWithOverridePropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithPrivatePropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestClassWithPublicPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithPublicProperty));
        }

        [TestMethod]
        public void TestClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithStaticPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithStaticProperty));
        }

        [TestMethod]
        public void TestClassWithVirtualPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithVirtualProperty));
        }
    }
}
