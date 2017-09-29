using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedAbstractClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithInternalPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewVirtualPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithOverridePropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPrivatePropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPublicPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPublicProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithStaticPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithVirtualPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithVirtualProperty));
        }
    }
}
