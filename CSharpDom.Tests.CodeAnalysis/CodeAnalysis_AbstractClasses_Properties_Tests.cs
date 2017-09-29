using CSharpDom.TestTarget.AbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithInternalPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewVirtualPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithOverridePropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivatePropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPublicProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithStaticProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithVirtualProperty));
        }
    }
}
