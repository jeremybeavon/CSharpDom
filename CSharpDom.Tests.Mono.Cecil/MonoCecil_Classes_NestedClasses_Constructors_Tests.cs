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
            TestClassAsync(typeof(ClassWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalConstructorUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateConstructorUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedConstructorUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalConstructorUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicConstructorUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicConstructor));
        }
    }
}
