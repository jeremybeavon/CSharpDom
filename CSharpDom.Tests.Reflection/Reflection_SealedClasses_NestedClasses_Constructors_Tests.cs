using CSharpDom.TestTarget.SealedClasses.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_SealedClasses_NestedClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstructorWith1AttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstructorWith1ParameterUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstructorWith2ParametersUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalConstructorUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateConstructorUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedConstructorUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalConstructorUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicConstructorUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicConstructor));
        }
    }
}
