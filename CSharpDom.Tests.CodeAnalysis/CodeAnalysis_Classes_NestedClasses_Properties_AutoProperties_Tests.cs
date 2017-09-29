using CSharpDom.TestTarget.Classes.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVirtualAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
