using CSharpDom.TestTarget.Classes.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        public MonoCecil_Classes_NestedClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWith1AttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalConstructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateConstructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedConstructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalConstructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicConstructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithPublicConstructor));
        }
    }
}
