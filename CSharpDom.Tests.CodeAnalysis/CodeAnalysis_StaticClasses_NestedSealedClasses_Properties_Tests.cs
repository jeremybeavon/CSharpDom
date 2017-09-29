using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedSealedClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithInternalPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithOverridePropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPrivatePropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPublicPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithStaticPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticProperty));
        }
    }
}
