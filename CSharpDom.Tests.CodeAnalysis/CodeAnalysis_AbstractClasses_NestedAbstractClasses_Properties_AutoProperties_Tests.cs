using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedAbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewVirtualAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithVirtualAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithVirtualAutoProperty));
        }
    }
}
