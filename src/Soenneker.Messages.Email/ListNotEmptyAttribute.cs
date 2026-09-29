using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Soenneker.Messages.Email;

/// <summary>Validates that an email recipient list has at least one entry without reflecting over collection members.</summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public sealed class ListNotEmptyAttribute : ValidationAttribute
{
    /// <summary>Creates the recipient-list validator.</summary>
    public ListNotEmptyAttribute() : base("The field {0} must contain at least one item.") { }

    /// <summary>Accepts null (handled by Required) or a non-empty list.</summary>
    /// <param name="value">The recipient list.</param>
    /// <returns>Whether the collection has a valid length.</returns>
    public override bool IsValid(object? value) => value is null or List<string> { Count: > 0 };
}
