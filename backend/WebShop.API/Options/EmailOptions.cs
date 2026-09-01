namespace WebShop.API.Options;

public sealed class EmailOptions
{
    public const string SectionName = "Email";

    /// <summary>
    /// From address for outbound mail.
    /// Format: <c>Майстриня &lt;noreply@maistrynia.local&gt;</c> or a bare email.
    /// </summary>
    public string From { get; set; } = "Майстриня <noreply@maistrynia.local>";
}
