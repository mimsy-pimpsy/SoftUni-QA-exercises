﻿using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] plants = new string[0];

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.Empty); 
    }

    // TODO: finish test
    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] plants = new string[]
        {
            "@--\\-"  // 5 chars
        };


        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo($"Plants with 5 letters:{Environment.NewLine}@--\\-"));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] plants = new string[]
        {
            "@--\\-",
            "*---",
            "----",
            "*-\\-\\"
        };


        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo($"Plants with 4 letters:{Environment.NewLine}*---{Environment.NewLine}----{Environment.NewLine}Plants with 5 letters:{Environment.NewLine}@--\\-{Environment.NewLine}*-\\-\\"));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] plants = new string[]
        {
            "rose",
            "daisy",
            "lily",
            "lotus"
        };
        StringBuilder sb = new();
        sb.AppendLine("Plants with 4 letters:");
        sb.AppendLine("rose");
        sb.AppendLine("lily");
        sb.AppendLine("Plants with 5 letters:");
        sb.AppendLine("daisy");
        sb.Append("lotus");

        string expected = sb.ToString();
            

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
