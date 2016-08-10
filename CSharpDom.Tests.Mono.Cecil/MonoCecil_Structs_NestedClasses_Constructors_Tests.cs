using CSharpDom.TestTarget.Structs.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        public MonoCecil_Structs_NestedClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalConstructorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateConstructorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedConstructorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalConstructorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicConstructorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicConstructor));
        }
    }
}
