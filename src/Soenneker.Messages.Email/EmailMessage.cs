using Newtonsoft.Json;
using Soenneker.Messages.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Soenneker.Enums.Email.Format;
using Soenneker.Enums.Email.Priority;

namespace Soenneker.Messages.Email;

/// <summary>
/// Represents a Service Bus message for email delivery.
/// </summary>
/// <remarks>
/// This message contains all metadata and content references required
/// to render and send an email. The base <see cref="Message"/> envelope
/// supplies routing and auditing information.
/// </remarks>
public sealed class EmailMessage : Message
{
    /// <summary>
    /// Gets the primary recipient email addresses.
    /// At least one recipient is required.
    /// </summary>
    [Required, MinLength(1)]
    [JsonPropertyName("to")]
    [JsonProperty("to", Required = Required.Always)]
    public required List<string> To { get; set; }

    /// <summary>
    /// Gets the Carbon Copy (CC) recipient email addresses.
    /// </summary>
    [JsonPropertyName("cc")]
    [JsonProperty("cc")]
    public List<string>? Cc { get; set; }

    /// <summary>
    /// Gets the Blind Carbon Copy (BCC) recipient email addresses.
    /// </summary>
    [JsonPropertyName("bcc")]
    [JsonProperty("bcc")]
    public List<string>? Bcc { get; set; }

    /// <summary>
    /// Gets the Reply-To email address.
    /// </summary>
    [JsonPropertyName("replyTo")]
    [JsonProperty("replyTo")]
    public string? ReplyTo { get; set; }

    /// <summary>
    /// Gets the display name of the sender.
    /// </summary>
    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets the sender email address.
    /// </summary>
    [JsonPropertyName("address")]
    [JsonProperty("address")]
    public string? Address { get; set; }

    /// <summary>
    /// Gets the subject line of the email.
    /// </summary>
    [Required]
    [JsonPropertyName("subject")]
    [JsonProperty("subject", Required = Required.Always)]
    public required string Subject { get; set; }

    /// <summary>
    /// Gets the file name containing the email body content.
    /// </summary>
    [JsonPropertyName("contentFileName")]
    [JsonProperty("contentFileName")]
    public string? ContentFileName { get; set; }

    /// <summary>
    /// Gets the optional template file name used to render the email.
    /// </summary>
    [JsonPropertyName("templateFileName")]
    [JsonProperty("templateFileName")]
    public string? TemplateFileName { get; set; }

    /// <summary>
    /// Gets the email body format (e.g., HTML or PlainText).
    /// </summary>
    [JsonPropertyName("format")]
    [JsonProperty("format")]
    public required EmailFormat Format { get; set; }

    /// <summary>
    /// Gets the priority level of the email.
    /// </summary>
    [JsonPropertyName("priority")]
    [JsonProperty("priority")]
    public required EmailPriority Priority { get; set; }

    /// <summary>
    /// Gets the token values used for template rendering.
    /// Keys correspond to placeholders within the template.
    /// </summary>
    [JsonPropertyName("tokens")]
    [JsonProperty("tokens")]
    public Dictionary<string, string>? Tokens { get; set; }

    /// <summary>
    /// Gets named partial template fragments available during rendering.
    /// </summary>
    [JsonPropertyName("partials")]
    [JsonProperty("partials")]
    public Dictionary<string, string>? Partials { get; set; }
}