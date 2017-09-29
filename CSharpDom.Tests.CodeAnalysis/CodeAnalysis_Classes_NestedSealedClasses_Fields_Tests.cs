using CSharpDom.TestTarget.Classes.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedSealedClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithVolatileFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithVolatileField));
        }
    }
}
