using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedAbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewVirtualAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVirtualAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualAutoProperty));
        }
    }
}
