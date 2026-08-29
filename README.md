[![](https://img.shields.io/nuget/v/soenneker.messages.email.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.messages.email/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.messages.email/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.messages.email/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.messages.email.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.messages.email/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.messages.email/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.messages.email/actions/workflows/codeql.yml)

# Soenneker.Messages.Email

Represents a Service Bus message for email delivery.

## Install

```bash
dotnet add package Soenneker.Messages.Email
```

## What you get

- `EmailMessage` — Represents a Service Bus message for email delivery.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `EmailMessage.To` | Gets the primary recipient email addresses. At least one recipient is required. | Gets the primary recipient email addresses. At least one recipient is required. |
| `EmailMessage.Cc` | Gets the Carbon Copy (CC) recipient email addresses. | Gets the Carbon Copy (CC) recipient email addresses. |
| `EmailMessage.Bcc` | Gets the Blind Carbon Copy (BCC) recipient email addresses. | Gets the Blind Carbon Copy (BCC) recipient email addresses. |
| `EmailMessage.ReplyTo` | Gets the Reply-To email address. | Gets the Reply-To email address. |
| `EmailMessage.Name` | Gets the display name of the sender. | Gets the display name of the sender. |
| `EmailMessage.Address` | Gets the sender email address. | Gets the sender email address. |
| `EmailMessage.Subject` | Gets the subject line of the email. | Gets the subject line of the email. |
| `EmailMessage.ContentFileName` | Gets the file name containing the email body content. | Gets the file name containing the email body content. |
| `EmailMessage.TemplateFileName` | Gets the optional template file name used to render the email. | Gets the optional template file name used to render the email. |
| `EmailMessage.Format` | Gets the email body format (e.g., HTML or PlainText). | Gets the email body format (e.g., HTML or PlainText). |
| `EmailMessage.Priority` | Gets the priority level of the email. | Gets the priority level of the email. |
| `EmailMessage.Tokens` | Gets the token values used for template rendering. Keys correspond to placeholders within the template. | Gets the token values used for template rendering. Keys correspond to placeholders within the template. |
| `EmailMessage.Partials` | Gets named partial template fragments available during rendering. | Gets named partial template fragments available during rendering. |

## Important behavior

- `EmailMessage`: This message contains all metadata and content references required to render and send an email. The base `Message` envelope supplies routing and auditing information.
