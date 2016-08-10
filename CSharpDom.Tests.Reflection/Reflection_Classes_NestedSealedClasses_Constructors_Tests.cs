using CSharpDom.TestTarget.Classes.NestedSealedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedSealedClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_Classes_NestedSealedClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstructorWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstructorWith1ParameterUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstructorWith2ParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalConstructorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateConstructorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedConstructorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalConstructorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicConstructorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicConstructor));
        }
    }
}
