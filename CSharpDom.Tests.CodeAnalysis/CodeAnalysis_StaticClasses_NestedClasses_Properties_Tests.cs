using CSharpDom.TestTarget.StaticClasses.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewVirtualPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverridePropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivatePropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualProperty));
        }
    }
}
