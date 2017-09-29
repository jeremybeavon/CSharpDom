using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedAbstractClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithInternalPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewVirtualPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithOverridePropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPrivatePropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPublicPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPublicProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithStaticPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithVirtualPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithVirtualProperty));
        }
    }
}
