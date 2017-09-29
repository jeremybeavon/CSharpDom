using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedAbstractClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewVirtualPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithOverridePropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivatePropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVirtualPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualProperty));
        }
    }
}
