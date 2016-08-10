using CSharpDom.TestTarget.Classes.NestedStructs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_Classes_NestedStructs_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }
        
        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWith1ParameterUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWith2ParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalConstructorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateConstructorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicConstructorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicConstructor));
        }
    }
}
