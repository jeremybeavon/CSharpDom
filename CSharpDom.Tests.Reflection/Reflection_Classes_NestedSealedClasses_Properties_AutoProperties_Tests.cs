using CSharpDom.TestTarget.Classes.NestedSealedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedSealedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverrideAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}
