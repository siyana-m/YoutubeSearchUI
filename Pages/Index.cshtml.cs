using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Reflection;

namespace YoutubeSearchAppInterface.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        [BindProperty]
        public string SearchTerm { get; set; }

        public IList<Models.Item> Videos { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (string.IsNullOrEmpty(SearchTerm))
            {
                Videos = null;
                return Page();
            }
            HttpClient httpClient = new HttpClient();
            string baseUrl = "https://www.googleapis.com/youtube/v3/search";
            string part = "snippet";
            string type = "video";
            string apiKey = "AIzaSyC_KSD7rol4YtJhuSFRVBQ1UmeWQ6ZIHks";
            string url =
           $"{baseUrl}?part={part}&q={SearchTerm}&type={type}&maxResults=9&key={apiKey}";
            var response = await httpClient.GetAsync(url);
            string responseBody = await response.Content.ReadAsStringAsync();
            var searchResponse =
           JsonConvert.DeserializeObject<Models.SearchResponse>(responseBody);
            Videos = searchResponse.Items;
            return Page();
        }

    }
}