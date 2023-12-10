using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class GroupingTests
{
    // TODO: finish test
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        List<int> input = new List<int>();

        // Act
        string result = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        List<int> input = new List<int>() { 2,3,2,5,6,7,8,2,13,4};
       
        StringBuilder sb = new();
        sb.AppendLine("Even numbers: 2, 2, 6, 8, 2, 4");
        sb.AppendLine("Odd numbers: 3, 5, 7, 13");
        
        string expected = sb.ToString().Trim();

        // Act
        string result = Grouping.GroupNumbers(input);

        Assert.That (result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        List<int> input = new List<int>() { 2, 2, 6, 6, 2, 8, 2, 12, 4 };

        StringBuilder sb = new();
        sb.AppendLine("Even numbers: 2, 2, 6, 6, 2, 8, 2, 12, 4");
       
        string expected = sb.ToString().Trim();

        // Act
        string result = Grouping.GroupNumbers(input);

        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        List<int> input = new List<int>() {1, 3, 13, 15, 7, 9, 13};

        StringBuilder sb = new();
        sb.AppendLine("Odd numbers: 1, 3, 13, 15, 7, 9, 13");

        string expected = sb.ToString().Trim();

        // Act
        string result = Grouping.GroupNumbers(input);

        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        List<int> input = new List<int>() { 0, 2,-7, 3, 2, 5, 6, 7, 8, 2, 13, 4 };

        StringBuilder sb = new();
        sb.AppendLine("Even numbers: 0, 2, 2, 6, 8, 2, 4");
        sb.AppendLine("Odd numbers: -7, 3, 5, 7, 13");

        string expected = sb.ToString().Trim();

        // Act
        string result = Grouping.GroupNumbers(input);

        Assert.That(result, Is.EqualTo(expected));
    }
}
