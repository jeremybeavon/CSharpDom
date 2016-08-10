using CSharpDom.TestTarget.Classes.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_Classes_NestedClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWith1ParameterUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWith2ParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalConstructorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateConstructorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedConstructorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalConstructorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicConstructorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicConstructor));
        }
    }
}
