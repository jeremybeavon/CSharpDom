using CSharpDom.TestTarget.Structs.NestedStructs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_Structs_NestedStructs_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWith1ParameterUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWith2ParametersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalConstructorUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateConstructorUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicConstructorUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithPublicConstructor));
        }
    }
}
