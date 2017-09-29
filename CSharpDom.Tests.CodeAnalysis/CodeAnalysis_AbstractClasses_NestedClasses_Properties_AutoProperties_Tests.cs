using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewVirtualAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVirtualAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
