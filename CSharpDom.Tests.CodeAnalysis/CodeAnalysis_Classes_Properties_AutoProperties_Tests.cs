using CSharpDom.TestTarget.Classes.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNewVirtualAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithVirtualAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithVirtualAutoProperty));
        }
    }
}
