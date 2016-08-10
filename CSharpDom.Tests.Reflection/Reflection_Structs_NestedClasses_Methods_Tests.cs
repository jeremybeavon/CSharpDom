using CSharpDom.TestTarget.Structs.NestedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith1GenericParameterUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith2GenericParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVirtualMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOverrideMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithSealedOverrideMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithStaticMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithVirtualMethod));
        }
    }
}
