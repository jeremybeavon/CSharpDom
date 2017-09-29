using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedSealedClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithInternalPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithOverridePropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPrivatePropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPublicPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithStaticPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithStaticProperty));
        }
    }
}
