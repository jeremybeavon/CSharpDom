using CSharpDom.TestTarget.SealedClasses.NestedStructs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStructs_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_SealedClasses_NestedStructs_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstructorWith1AttributeUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstructorWith1ParameterUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstructorWith2ParametersUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalConstructorUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithInternalConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivateConstructorUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithPrivateConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicConstructorUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithPublicConstructor));
        }
    }
}
