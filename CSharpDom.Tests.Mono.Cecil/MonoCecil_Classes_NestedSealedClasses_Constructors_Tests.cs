using CSharpDom.TestTarget.Classes.NestedSealedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedSealedClasses_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        public MonoCecil_Classes_NestedSealedClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstructorWith1AttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalConstructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateConstructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedConstructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalConstructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicConstructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPublicConstructor));
        }
    }
}
