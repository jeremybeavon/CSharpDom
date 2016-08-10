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
            TestClassAsync(typeof(ClassWithNestedStructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalConstructorUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateConstructorUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicConstructorUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicConstructor));
        }
    }
}
