using CSharpDom.TestTarget.Classes.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithInternalPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVirtualPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOverridePropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivatePropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithVirtualProperty));
        }
    }
}
