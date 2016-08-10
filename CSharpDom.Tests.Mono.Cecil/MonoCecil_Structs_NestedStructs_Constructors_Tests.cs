using CSharpDom.TestTarget.Structs.NestedStructs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStructs_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        public MonoCecil_Structs_NestedStructs_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalConstructorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateConstructorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicConstructorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicConstructor));
        }
    }
}
