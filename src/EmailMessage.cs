﻿using Newtonsoft.Json;
using Soenneker.Messages.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Soenneker.Enums.Email.Format;
using Soenneker.Enums.Email.Priority;

namespace Soenneker.Messages.Email;

/// <summary>
/// A Service Bus message for emails
/// </summary>
public class EmailMessage : Message
{
    /// <summary>
    /// List of recipient email addresses.
    /// </summary>
    [Required, MinLength(1)]
    [JsonPropertyName("to")]
    [JsonProperty("to")]
    public List<string> To { get; set; } = null!;

    /// <summary>
    /// List of Carbon Copy (CC) recipient email addresses.
    /// </summary>
    [JsonPropertyName("cc")]
    [JsonProperty("cc")]
    public List<string>? Cc { get; set; }

    /// <summary>
    /// List of Blind Carbon Copy (BCC) recipient email addresses.
    /// </summary>
    [JsonPropertyName("bcc")]
    [JsonProperty("bcc")]
    public List<string>? Bcc { get; set; }

    /// <summary>
    /// Email address used in the Reply-To header.
    /// </summary>
    [JsonPropertyName("replyTo")]
    [JsonProperty("replyTo")]
    public string? ReplyTo { get; set; }

    /// <summary>
    /// Display name of the sender.
    /// </summary>
    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Email address of the sender.
    /// </summary>
    [JsonPropertyName("address")]
    [JsonProperty("address")]
    public string Address { get; set; } = null!;

    /// <summary>
    /// Subject of the email message.
    /// </summary>
    [JsonPropertyName("subject")]
    [JsonProperty("subject")]
    public string Subject { get; set; } = null!;

    /// <summary>
    /// Path to the file containing the email body content.
    /// </summary>
    [JsonPropertyName("bodyFile")]
    [JsonProperty("bodyFile")]
    public string BodyFile { get; set; } = null!;

    /// <summary>
    /// Optional path to a file used as the template for the email.
    /// </summary>
    [JsonPropertyName("templateFile")]
    [JsonProperty("templateFile")]
    public string? TemplateFile { get; set; }

    /// <summary>
    /// Format of the email body (e.g., HTML or PlainText).
    /// </summary>
    [JsonPropertyName("format")]
    [JsonProperty("format")]
    public EmailFormat Format { get; set; }

    /// <summary>
    /// Priority of the email (e.g., Low, Normal, High).
    /// </summary>
    [JsonPropertyName("priority")]
    [JsonProperty("priority")]
    public EmailPriority Priority { get; set; }

    /// <summary>
    /// Constructs a new <see cref="EmailMessage"/> and sets the service bus queue as "email".
    /// </summary>
    public EmailMessage() : base("email")
    {
    }
}