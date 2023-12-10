using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        string[]input = Array.Empty<string>();

        string result = OddOccurrences.FindOdd(input);

        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = { "mims", "mims" }
;        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        // Arrange
        string[] input = { "mims", "mims", "mims"} 
;        // Act
        string result = OddOccurrences.FindOdd(input);

        //Assert
        Assert.That(result, Is.EqualTo("mims"));

    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        // Arrange
        string[] input = { "mims", "mims", "zdrasti", "zdrasti", "zdrasti", "a", "a", "a", }
;        // Act
        string result = OddOccurrences.FindOdd(input);

        //Assert
        Assert.That(result, Is.EqualTo("zdrasti a"));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = { "mims", "mims", "ZDRASTI", "zdrasti", "zdrasti", "a", "a", "A", }
;        // Act
        string result = OddOccurrences.FindOdd(input);

        //Assert
        Assert.That(result, Is.EqualTo("zdrasti a"));
    }
}
