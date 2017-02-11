using CSharpDom.TestTarget.Classes.NestedStructs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStructs_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        public MonoCecil_Classes_NestedStructs_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWith1AttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalConstructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateConstructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithPrivateConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicConstructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithPublicConstructor));
        }
    }
}
