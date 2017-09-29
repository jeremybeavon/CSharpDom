using CSharpDom.TestTarget.StaticClasses.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewVirtualAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
