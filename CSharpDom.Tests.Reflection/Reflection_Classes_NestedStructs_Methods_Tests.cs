using CSharpDom.TestTarget.Classes.NestedStructs.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithMethodWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithMethodWith1GenericParameterUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithMethodWith2GenericParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithInternalMethod));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateMethod));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicMethod));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithStaticMethod));
        }
    }
}
