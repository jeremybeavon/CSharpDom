using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedSealedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}
