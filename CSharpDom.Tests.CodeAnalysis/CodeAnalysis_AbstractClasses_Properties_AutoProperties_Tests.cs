using CSharpDom.TestTarget.AbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewVirtualAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithVirtualAutoProperty));
        }
    }
}
