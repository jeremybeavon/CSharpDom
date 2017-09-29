using CSharpDom.TestTarget.Classes.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedSealedClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverridePropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivatePropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticProperty));
        }
    }
}
