using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedSealedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}
