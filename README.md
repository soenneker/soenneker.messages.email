# Soenneker.Messages.Email
[![](https://img.shields.io/nuget/v/soenneker.messages.email.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.messages.email/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.messages.email/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.messages.email/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.messages.email.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.messages.email/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.messages.email/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.messages.email/actions/workflows/codeql.yml)

Defines an email-delivery message envelope with recipients, sender overrides, content references, rendering tokens, format, and priority.

## Installation

```bash
dotnet add package Soenneker.Messages.Email
```

## Create a message

```csharp
using Soenneker.Enums.Email.Format;
using Soenneker.Enums.Email.Priority;
using Soenneker.Messages.Email;

var message = new EmailMessage
{
    Type = "email.delivery.v1",
    Id = Guid.NewGuid().ToString("N"),
    Queue = "email",
    Sender = "accounts-api",
    CreatedAt = DateTimeOffset.UtcNow,

    To = ["person@example.com"],
    ReplyTo = "support@example.com",
    Subject = "Welcome",
    ContentFileName = "welcome.html",
    TemplateFileName = "layout.html",
    Format = EmailFormat.Html,
    Priority = EmailPriority.Normal,
    Tokens = new Dictionary<string, string>
    {
        ["firstName"] = "Sam"
    }
};
```

Available formats are `EmailFormat.Plaintext` and `EmailFormat.Html`. Priorities are `EmailPriority.Low`, `EmailPriority.Normal`, and `EmailPriority.High`.

`Cc`, `Bcc`, `ReplyTo`, sender `Name` and `Address`, `ContentFileName`, `TemplateFileName`, `Tokens`, and `Partials` are optional. How missing sender or content fields are resolved is the responsibility of the receiving email service.

## Consumer responsibilities

This package is a serializable contract. It does not read content files, render templates, send email, or validate the message automatically. The receiving service should:

- validate every recipient and sender address;
- require at least one non-empty `To` entry and a non-empty subject;
- treat file names as untrusted input and constrain resolved paths to approved content directories;
- define the token and partial syntax used by its template engine;
- avoid logging recipient data, token values, or rendered bodies when they may contain personal or sensitive information.

The `[Required]` and `[MinLength]` attributes are metadata for a validation framework; serialization alone does not execute them.
