using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewVirtualPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOverridePropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivatePropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVirtualPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVirtualProperty));
        }
    }
}
