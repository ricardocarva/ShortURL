using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ShortURL;

public class URL
{
    public string OriginalURL { get; set; } = string.Empty;
    public string ShortenedUrl { get; set; } = string.Empty;

}