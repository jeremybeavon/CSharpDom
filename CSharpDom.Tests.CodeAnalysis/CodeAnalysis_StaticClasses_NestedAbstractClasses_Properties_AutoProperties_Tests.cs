using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedAbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewVirtualAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithVirtualAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithVirtualAutoProperty));
        }
    }
}
